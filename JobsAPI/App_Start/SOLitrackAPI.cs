﻿using System;
using System.ServiceModel;
using DBSpoolConfiguration;

/// <summary>
/// SOLitrackJobAPI
/// </summary>
public class SOLitrackJobAPI : SOLitrackWebServiceClient<DBSpoolJobAPIClient, IDBSpoolJobAPI>
{
    private string m_solitrackHostMachine;
    public SOLitrackJobAPI(string solitrackHostMachine) { m_solitrackHostMachine = solitrackHostMachine; }
    protected override DBSpoolJobAPIClient Connect()
    {
        return new DBSpoolJobAPIClient(NetTcpBinding(), Endpoint(m_solitrackHostMachine, "JobManagerAPI"));
    }
}

/// <summary>
/// SOLitrackDeviceAPI
/// </summary>
public class SOLitrackDeviceAPI : SOLitrackWebServiceClient<DBSpoolDeviceAPIClient, IDBSpoolDeviceAPI>
{
    private string m_solitrackHostMachine;
    public SOLitrackDeviceAPI(string solitrackHostMachine) { m_solitrackHostMachine = solitrackHostMachine; }
    protected override DBSpoolDeviceAPIClient Connect()
    {
        return new DBSpoolDeviceAPIClient(NetTcpBinding(), Endpoint(m_solitrackHostMachine, "DeviceManagerAPI"));
    }
}

/// <summary>
/// SOLitrackMonitorAPI
/// </summary>
public class SOLitrackMonitorAPI : SOLitrackWebServiceClient<DBSpoolMonitorAPIClient, IDBSpoolMonitorAPI>
{
    private string m_solitrackHostMachine;
    public SOLitrackMonitorAPI(string solitrackHostMachine) { m_solitrackHostMachine = solitrackHostMachine; }
    protected override DBSpoolMonitorAPIClient Connect()
    {
        return new DBSpoolMonitorAPIClient(NetTcpBinding(), Endpoint(m_solitrackHostMachine, "MonitorManagerAPI"));
    }
}

/// <summary>
/// SOLitrackWorkflowAPI
/// </summary>
public class SOLitrackWorkflowAPI : SOLitrackWebServiceClient<DBSpoolWorkflowAPIClient, IDBSpoolWorkflowAPI>
{
    private string m_solitrackHostMachine;
    public SOLitrackWorkflowAPI(string solitrackHostMachine) { m_solitrackHostMachine = solitrackHostMachine; }
    protected override DBSpoolWorkflowAPIClient Connect()
    {
        return new DBSpoolWorkflowAPIClient(NetTcpBinding(), Endpoint(m_solitrackHostMachine, "WorkflowManagerAPI"));
    }
}

/// <summary>
/// SOLitrackApplicationAPI
/// </summary>
public class SOLitrackApplicationAPI : SOLitrackWebServiceClient<DBSpoolApplicationAPIClient, IDBSpoolApplicationAPI>
{
    private string m_solitrackHostMachine;
    public SOLitrackApplicationAPI(string solitrackHostMachine) { m_solitrackHostMachine = solitrackHostMachine; }
    protected override DBSpoolApplicationAPIClient Connect()
    {
        return new DBSpoolApplicationAPIClient(NetTcpBinding(), Endpoint(m_solitrackHostMachine, "ApplicationManagerAPI"));
    }
}

/// <summary>
/// SOLitrackCheckpointAPI
/// </summary>
public class SOLitrackCheckpointAPI : SOLitrackWebServiceClient<DBSpoolCheckpointAPIClient, IDBSpoolCheckpointAPI>
{
    private string m_solitrackHostMachine;
    public SOLitrackCheckpointAPI(string solitrackHostMachine) { m_solitrackHostMachine = solitrackHostMachine; }
    protected override DBSpoolCheckpointAPIClient Connect()
    {
        return new DBSpoolCheckpointAPIClient(NetTcpBinding(), Endpoint(m_solitrackHostMachine, "CheckpointManagerAPI"));
    }
}

/// <summary>
/// Provides binding and endpoint methods to DBSpoolServiceProxy.
/// </summary>
/// <typeparam name="TProxy"></typeparam>
/// <typeparam name="TChannel"></typeparam>
abstract public class SOLitrackWebServiceClient<TProxy, TChannel> : DBSpoolServiceProxy<TProxy, TChannel>, IDisposable
    where TProxy : ClientBase<TChannel>
    where TChannel : class
{
    protected NetTcpBinding NetTcpBinding()
    {
        NetTcpBinding binding = new NetTcpBinding(SecurityMode.Transport);
        binding.Security.Message.ClientCredentialType = MessageCredentialType.Windows;
        binding.ListenBacklog = 300;
        binding.PortSharingEnabled = true;
        binding.ReceiveTimeout = TimeSpan.MaxValue;
        binding.MaxReceivedMessageSize = Int32.MaxValue;
        binding.MaxConnections = 300;
        binding.ReaderQuotas.MaxArrayLength = Int32.MaxValue;
        binding.ReaderQuotas.MaxDepth = Int32.MaxValue;
        binding.ReaderQuotas.MaxStringContentLength = Int32.MaxValue;
        binding.ReaderQuotas.MaxBytesPerRead = Int32.MaxValue;
        binding.ReaderQuotas.MaxNameTableCharCount = Int32.MaxValue;
        return binding;
    }
    protected EndpointAddress Endpoint(string host, string endpointName)
    {
        return new EndpointAddress(new Uri(String.Format("net.tcp://{0}/DBSpoolConfiguration/{1}", host, endpointName)), EndpointIdentity.CreateSpnIdentity(""));
    }
}

/// <summary>
/// Helper class to manage WCF Service Proxies. When accessing the
/// Proxy via the Client member, if the client is closed or faulted,
/// a new connection will automatically be attempted.
/// </summary>
/// <typeparam name="TProxy">The client class generated by svcutil.exe</typeparam>
/// <typeparam name="TChannel">The name of the Interface</typeparam>
abstract public class DBSpoolServiceProxy<TProxy, TChannel> : IDisposable
    where TProxy : ClientBase<TChannel>
    where TChannel : class
{
    private object m_proxyLock = new object();
    private TProxy m_proxy = null;
    private bool m_disposed = false;

    public TProxy Client
    {
        get
        {
            lock (m_proxyLock)
            {
                if (m_proxy == null ||
                    m_proxy.InnerChannel == null ||
                    m_proxy.State == CommunicationState.Closing ||
                    m_proxy.State == CommunicationState.Closed ||
                    m_proxy.State == CommunicationState.Faulted ||
                    m_proxy.InnerChannel.State == CommunicationState.Closing ||
                    m_proxy.InnerChannel.State == CommunicationState.Closed ||
                    m_proxy.InnerChannel.State == CommunicationState.Faulted)
                {
                    m_proxy = Connect();
                    if (m_proxy != null && m_proxy.InnerChannel != null)
                    {
                        m_proxy.InnerChannel.Faulted += new EventHandler(InnerChannel_Faulted);
                    }
                }
            }
            return m_proxy;
        }
    }

    /// <summary>
    /// Try and recreate the channel if it becomes faulted for any reason.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void InnerChannel_Faulted(object sender, EventArgs e)
    {
        try
        {
            lock (m_proxyLock)
            {
                AbortProxy();
                m_proxy = null;
                m_proxy = Connect();
                if (m_proxy != null && m_proxy.InnerChannel != null)
                {
                    m_proxy.InnerChannel.Faulted += new EventHandler(InnerChannel_Faulted);
                }
            }
        }
        catch
        {
            ; // absorb
        }
    }

    /// <summary>
    /// Creates the underlying proxies.
    /// </summary>
    /// <returns>TProxy</returns>
    protected abstract TProxy Connect();

    ~DBSpoolServiceProxy() { Dispose(false); }

    /// <summary>
    /// Dispose
    /// </summary>
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    /// <summary>
    /// Aborts the underlying proxy.
    /// </summary>
    private void AbortProxy() { try { m_proxy.Abort(); } catch { /*absorb*/ } }

    /// <summary>
    /// Dispose
    /// </summary>
    /// <param name="disposing"></param>
    private void Dispose(bool disposing)
    {
        lock (m_proxyLock)
        {
            if (!m_disposed)
            {
                if (m_proxy != null)
                {
                    try
                    {
                        m_proxy.Close();
                    }
                    catch (CommunicationException) { AbortProxy(); }
                    catch (TimeoutException) { AbortProxy(); }
                    catch (Exception) { AbortProxy(); throw; }
                    finally { m_proxy = null; }
                }
                m_disposed = true;
            }
        }
    }
}

