using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.ComponentModel;
using System.Collections.Generic;
using DBSpoolConfiguration;

namespace DBSpoolConfiguration
{
#if SERVICEDEF
	[DataContract]
#endif
	public partial class WebEnumDeviceStatusType
	{
		public WebEnumDeviceStatusType(DeviceStatusType value)
		{
			Value = value;
			IntValue = (int)value;
		}
#if SERVICEDEF
		[DataMember]
		internal int IntValue { get; set; }
#endif
		public DeviceStatusType Value { get; set; }
		public static implicit operator WebEnumDeviceStatusType(DeviceStatusType value)
		{
			return new WebEnumDeviceStatusType(value);
		}
		public static implicit operator DeviceStatusType(WebEnumDeviceStatusType value)
		{
			return (DeviceStatusType)Enum.ToObject(typeof(DeviceStatusType), value.IntValue);
		}
		public static bool operator ==(WebEnumDeviceStatusType e1, WebEnumDeviceStatusType e2)
		{
			return (e1.GetType() == e2.GetType() && e1.IntValue == e2.IntValue);
		}
		public static bool operator !=(WebEnumDeviceStatusType e1, WebEnumDeviceStatusType e2)
		{
			return (e1.GetType() != e2.GetType() || e1.IntValue != e2.IntValue);
		}
		public override bool Equals(object obj)
		{
			return this == obj as WebEnumDeviceStatusType;
		}
		public override int GetHashCode()
		{
			return this.IntValue;
		}
		[OnDeserialized]
		internal void OnDeserialized(StreamingContext context)
		{
			if (Enum.IsDefined(typeof(DeviceStatusType), IntValue))
			{
				Value = (DeviceStatusType)Enum.ToObject(typeof(DeviceStatusType), IntValue);
			}
			else
			{
				Value = default(DeviceStatusType);
			}
		}
	}

#if SERVICEDEF
	[DataContract]
#endif
	public partial class WebEnumSecurableType
	{
		public WebEnumSecurableType(SecurableType value)
		{
			Value = value;
			IntValue = (int)value;
		}
#if SERVICEDEF
		[DataMember]
		internal int IntValue { get; set; }
#endif
		public SecurableType Value { get; set; }
		public static implicit operator WebEnumSecurableType(SecurableType value)
		{
			return new WebEnumSecurableType(value);
		}
		public static implicit operator SecurableType(WebEnumSecurableType value)
		{
			return (SecurableType)Enum.ToObject(typeof(SecurableType), value.IntValue);
		}
		public static bool operator ==(WebEnumSecurableType e1, WebEnumSecurableType e2)
		{
			return (e1.GetType() == e2.GetType() && e1.IntValue == e2.IntValue);
		}
		public static bool operator !=(WebEnumSecurableType e1, WebEnumSecurableType e2)
		{
			return (e1.GetType() != e2.GetType() || e1.IntValue != e2.IntValue);
		}
		public override bool Equals(object obj)
		{
			return this == obj as WebEnumSecurableType;
		}
		public override int GetHashCode()
		{
			return this.IntValue;
		}
		[OnDeserialized]
		internal void OnDeserialized(StreamingContext context)
		{
			if (Enum.IsDefined(typeof(SecurableType), IntValue))
			{
				Value = (SecurableType)Enum.ToObject(typeof(SecurableType), IntValue);
			}
			else
			{
				Value = default(SecurableType);
			}
		}
	}

#if SERVICEDEF
	[DataContract]
#endif
	public partial class WebEnumJobTerminationAction
	{
		public WebEnumJobTerminationAction(JobTerminationAction value)
		{
			Value = value;
			IntValue = (int)value;
		}
#if SERVICEDEF
		[DataMember]
		internal int IntValue { get; set; }
#endif
		public JobTerminationAction Value { get; set; }
		public static implicit operator WebEnumJobTerminationAction(JobTerminationAction value)
		{
			return new WebEnumJobTerminationAction(value);
		}
		public static implicit operator JobTerminationAction(WebEnumJobTerminationAction value)
		{
			return (JobTerminationAction)Enum.ToObject(typeof(JobTerminationAction), value.IntValue);
		}
		public static bool operator ==(WebEnumJobTerminationAction e1, WebEnumJobTerminationAction e2)
		{
			return (e1.GetType() == e2.GetType() && e1.IntValue == e2.IntValue);
		}
		public static bool operator !=(WebEnumJobTerminationAction e1, WebEnumJobTerminationAction e2)
		{
			return (e1.GetType() != e2.GetType() || e1.IntValue != e2.IntValue);
		}
		public override bool Equals(object obj)
		{
			return this == obj as WebEnumJobTerminationAction;
		}
		public override int GetHashCode()
		{
			return this.IntValue;
		}
		[OnDeserialized]
		internal void OnDeserialized(StreamingContext context)
		{
			if (Enum.IsDefined(typeof(JobTerminationAction), IntValue))
			{
				Value = (JobTerminationAction)Enum.ToObject(typeof(JobTerminationAction), IntValue);
			}
			else
			{
				Value = default(JobTerminationAction);
			}
		}
	}

#if SERVICEDEF
	[DataContract]
#endif
	public partial class WebEnumJobState
	{
		public WebEnumJobState(JobState value)
		{
			Value = value;
			IntValue = (int)value;
		}
#if SERVICEDEF
		[DataMember]
		internal int IntValue { get; set; }
#endif
		public JobState Value { get; set; }
		public static implicit operator WebEnumJobState(JobState value)
		{
			return new WebEnumJobState(value);
		}
		public static implicit operator JobState(WebEnumJobState value)
		{
			return (JobState)Enum.ToObject(typeof(JobState), value.IntValue);
		}
		public static bool operator ==(WebEnumJobState e1, WebEnumJobState e2)
		{
			return (e1.GetType() == e2.GetType() && e1.IntValue == e2.IntValue);
		}
		public static bool operator !=(WebEnumJobState e1, WebEnumJobState e2)
		{
			return (e1.GetType() != e2.GetType() || e1.IntValue != e2.IntValue);
		}
		public override bool Equals(object obj)
		{
			return this == obj as WebEnumJobState;
		}
		public override int GetHashCode()
		{
			return this.IntValue;
		}
		[OnDeserialized]
		internal void OnDeserialized(StreamingContext context)
		{
			if (Enum.IsDefined(typeof(JobState), IntValue))
			{
				Value = (JobState)Enum.ToObject(typeof(JobState), IntValue);
			}
			else
			{
				Value = default(JobState);
			}
		}
	}

#if SERVICEDEF
	[DataContract]
#endif
	public partial class WebEnumJobMessageType
	{
		public WebEnumJobMessageType(JobMessageType value)
		{
			Value = value;
			IntValue = (int)value;
		}
#if SERVICEDEF
		[DataMember]
		internal int IntValue { get; set; }
#endif
		public JobMessageType Value { get; set; }
		public static implicit operator WebEnumJobMessageType(JobMessageType value)
		{
			return new WebEnumJobMessageType(value);
		}
		public static implicit operator JobMessageType(WebEnumJobMessageType value)
		{
			return (JobMessageType)Enum.ToObject(typeof(JobMessageType), value.IntValue);
		}
		public static bool operator ==(WebEnumJobMessageType e1, WebEnumJobMessageType e2)
		{
			return (e1.GetType() == e2.GetType() && e1.IntValue == e2.IntValue);
		}
		public static bool operator !=(WebEnumJobMessageType e1, WebEnumJobMessageType e2)
		{
			return (e1.GetType() != e2.GetType() || e1.IntValue != e2.IntValue);
		}
		public override bool Equals(object obj)
		{
			return this == obj as WebEnumJobMessageType;
		}
		public override int GetHashCode()
		{
			return this.IntValue;
		}
		[OnDeserialized]
		internal void OnDeserialized(StreamingContext context)
		{
			if (Enum.IsDefined(typeof(JobMessageType), IntValue))
			{
				Value = (JobMessageType)Enum.ToObject(typeof(JobMessageType), IntValue);
			}
			else
			{
				Value = default(JobMessageType);
			}
		}
	}

#if SERVICEDEF
	[DataContract]
#endif
	public partial class WebEnumDeviceType
	{
		public WebEnumDeviceType(DeviceType value)
		{
			Value = value;
			IntValue = (int)value;
		}
#if SERVICEDEF
		[DataMember]
		internal int IntValue { get; set; }
#endif
		public DeviceType Value { get; set; }
		public static implicit operator WebEnumDeviceType(DeviceType value)
		{
			return new WebEnumDeviceType(value);
		}
		public static implicit operator DeviceType(WebEnumDeviceType value)
		{
			return (DeviceType)Enum.ToObject(typeof(DeviceType), value.IntValue);
		}
		public static bool operator ==(WebEnumDeviceType e1, WebEnumDeviceType e2)
		{
			return (e1.GetType() == e2.GetType() && e1.IntValue == e2.IntValue);
		}
		public static bool operator !=(WebEnumDeviceType e1, WebEnumDeviceType e2)
		{
			return (e1.GetType() != e2.GetType() || e1.IntValue != e2.IntValue);
		}
		public override bool Equals(object obj)
		{
			return this == obj as WebEnumDeviceType;
		}
		public override int GetHashCode()
		{
			return this.IntValue;
		}
		[OnDeserialized]
		internal void OnDeserialized(StreamingContext context)
		{
			if (Enum.IsDefined(typeof(DeviceType), IntValue))
			{
				Value = (DeviceType)Enum.ToObject(typeof(DeviceType), IntValue);
			}
			else
			{
				Value = default(DeviceType);
			}
		}
	}

#if SERVICEDEF
	[DataContract]
#endif
	public partial class WebEnumDeviceSelectionMode
	{
		public WebEnumDeviceSelectionMode(DeviceSelectionMode value)
		{
			Value = value;
			IntValue = (int)value;
		}
#if SERVICEDEF
		[DataMember]
		internal int IntValue { get; set; }
#endif
		public DeviceSelectionMode Value { get; set; }
		public static implicit operator WebEnumDeviceSelectionMode(DeviceSelectionMode value)
		{
			return new WebEnumDeviceSelectionMode(value);
		}
		public static implicit operator DeviceSelectionMode(WebEnumDeviceSelectionMode value)
		{
			return (DeviceSelectionMode)Enum.ToObject(typeof(DeviceSelectionMode), value.IntValue);
		}
		public static bool operator ==(WebEnumDeviceSelectionMode e1, WebEnumDeviceSelectionMode e2)
		{
			return (e1.GetType() == e2.GetType() && e1.IntValue == e2.IntValue);
		}
		public static bool operator !=(WebEnumDeviceSelectionMode e1, WebEnumDeviceSelectionMode e2)
		{
			return (e1.GetType() != e2.GetType() || e1.IntValue != e2.IntValue);
		}
		public override bool Equals(object obj)
		{
			return this == obj as WebEnumDeviceSelectionMode;
		}
		public override int GetHashCode()
		{
			return this.IntValue;
		}
		[OnDeserialized]
		internal void OnDeserialized(StreamingContext context)
		{
			if (Enum.IsDefined(typeof(DeviceSelectionMode), IntValue))
			{
				Value = (DeviceSelectionMode)Enum.ToObject(typeof(DeviceSelectionMode), IntValue);
			}
			else
			{
				Value = default(DeviceSelectionMode);
			}
		}
	}

#if SERVICEDEF
	[DataContract]
#endif
	public partial class WebEnumJobAction
	{
		public WebEnumJobAction(JobAction value)
		{
			Value = value;
			IntValue = (int)value;
		}
#if SERVICEDEF
		[DataMember]
		internal int IntValue { get; set; }
#endif
		public JobAction Value { get; set; }
		public static implicit operator WebEnumJobAction(JobAction value)
		{
			return new WebEnumJobAction(value);
		}
		public static implicit operator JobAction(WebEnumJobAction value)
		{
			return (JobAction)Enum.ToObject(typeof(JobAction), value.IntValue);
		}
		public static bool operator ==(WebEnumJobAction e1, WebEnumJobAction e2)
		{
			return (e1.GetType() == e2.GetType() && e1.IntValue == e2.IntValue);
		}
		public static bool operator !=(WebEnumJobAction e1, WebEnumJobAction e2)
		{
			return (e1.GetType() != e2.GetType() || e1.IntValue != e2.IntValue);
		}
		public override bool Equals(object obj)
		{
			return this == obj as WebEnumJobAction;
		}
		public override int GetHashCode()
		{
			return this.IntValue;
		}
		[OnDeserialized]
		internal void OnDeserialized(StreamingContext context)
		{
			if (Enum.IsDefined(typeof(JobAction), IntValue))
			{
				Value = (JobAction)Enum.ToObject(typeof(JobAction), IntValue);
			}
			else
			{
				Value = default(JobAction);
			}
		}
	}

#if SERVICEDEF
	[DataContract]
#endif
	public partial class WebEnumFolderScope
	{
		public WebEnumFolderScope(FolderScope value)
		{
			Value = value;
			IntValue = (int)value;
		}
#if SERVICEDEF
		[DataMember]
		internal int IntValue { get; set; }
#endif
		public FolderScope Value { get; set; }
		public static implicit operator WebEnumFolderScope(FolderScope value)
		{
			return new WebEnumFolderScope(value);
		}
		public static implicit operator FolderScope(WebEnumFolderScope value)
		{
			return (FolderScope)Enum.ToObject(typeof(FolderScope), value.IntValue);
		}
		public static bool operator ==(WebEnumFolderScope e1, WebEnumFolderScope e2)
		{
			return (e1.GetType() == e2.GetType() && e1.IntValue == e2.IntValue);
		}
		public static bool operator !=(WebEnumFolderScope e1, WebEnumFolderScope e2)
		{
			return (e1.GetType() != e2.GetType() || e1.IntValue != e2.IntValue);
		}
		public override bool Equals(object obj)
		{
			return this == obj as WebEnumFolderScope;
		}
		public override int GetHashCode()
		{
			return this.IntValue;
		}
		[OnDeserialized]
		internal void OnDeserialized(StreamingContext context)
		{
			if (Enum.IsDefined(typeof(FolderScope), IntValue))
			{
				Value = (FolderScope)Enum.ToObject(typeof(FolderScope), IntValue);
			}
			else
			{
				Value = default(FolderScope);
			}
		}
	}

#if SERVICEDEF
	[DataContract]
#endif
	public partial class WebEnumFolderSpecializedType
	{
		public WebEnumFolderSpecializedType(FolderSpecializedType value)
		{
			Value = value;
			IntValue = (int)value;
		}
#if SERVICEDEF
		[DataMember]
		internal int IntValue { get; set; }
#endif
		public FolderSpecializedType Value { get; set; }
		public static implicit operator WebEnumFolderSpecializedType(FolderSpecializedType value)
		{
			return new WebEnumFolderSpecializedType(value);
		}
		public static implicit operator FolderSpecializedType(WebEnumFolderSpecializedType value)
		{
			return (FolderSpecializedType)Enum.ToObject(typeof(FolderSpecializedType), value.IntValue);
		}
		public static bool operator ==(WebEnumFolderSpecializedType e1, WebEnumFolderSpecializedType e2)
		{
			return (e1.GetType() == e2.GetType() && e1.IntValue == e2.IntValue);
		}
		public static bool operator !=(WebEnumFolderSpecializedType e1, WebEnumFolderSpecializedType e2)
		{
			return (e1.GetType() != e2.GetType() || e1.IntValue != e2.IntValue);
		}
		public override bool Equals(object obj)
		{
			return this == obj as WebEnumFolderSpecializedType;
		}
		public override int GetHashCode()
		{
			return this.IntValue;
		}
		[OnDeserialized]
		internal void OnDeserialized(StreamingContext context)
		{
			if (Enum.IsDefined(typeof(FolderSpecializedType), IntValue))
			{
				Value = (FolderSpecializedType)Enum.ToObject(typeof(FolderSpecializedType), IntValue);
			}
			else
			{
				Value = default(FolderSpecializedType);
			}
		}
	}

#if SERVICEDEF
	[DataContract]
#endif
	public partial class WebEnumFolderType
	{
		public WebEnumFolderType(FolderType value)
		{
			Value = value;
			IntValue = (int)value;
		}
#if SERVICEDEF
		[DataMember]
		internal int IntValue { get; set; }
#endif
		public FolderType Value { get; set; }
		public static implicit operator WebEnumFolderType(FolderType value)
		{
			return new WebEnumFolderType(value);
		}
		public static implicit operator FolderType(WebEnumFolderType value)
		{
			return (FolderType)Enum.ToObject(typeof(FolderType), value.IntValue);
		}
		public static bool operator ==(WebEnumFolderType e1, WebEnumFolderType e2)
		{
			return (e1.GetType() == e2.GetType() && e1.IntValue == e2.IntValue);
		}
		public static bool operator !=(WebEnumFolderType e1, WebEnumFolderType e2)
		{
			return (e1.GetType() != e2.GetType() || e1.IntValue != e2.IntValue);
		}
		public override bool Equals(object obj)
		{
			return this == obj as WebEnumFolderType;
		}
		public override int GetHashCode()
		{
			return this.IntValue;
		}
		[OnDeserialized]
		internal void OnDeserialized(StreamingContext context)
		{
			if (Enum.IsDefined(typeof(FolderType), IntValue))
			{
				Value = (FolderType)Enum.ToObject(typeof(FolderType), IntValue);
			}
			else
			{
				Value = default(FolderType);
			}
		}
	}

#if SERVICEDEF
	[DataContract]
#endif
	public partial class WebEnumAccountingLogDelimiter
	{
		public WebEnumAccountingLogDelimiter(AccountingLogDelimiter value)
		{
			Value = value;
			IntValue = (int)value;
		}
#if SERVICEDEF
		[DataMember]
		internal int IntValue { get; set; }
#endif
		public AccountingLogDelimiter Value { get; set; }
		public static implicit operator WebEnumAccountingLogDelimiter(AccountingLogDelimiter value)
		{
			return new WebEnumAccountingLogDelimiter(value);
		}
		public static implicit operator AccountingLogDelimiter(WebEnumAccountingLogDelimiter value)
		{
			return (AccountingLogDelimiter)Enum.ToObject(typeof(AccountingLogDelimiter), value.IntValue);
		}
		public static bool operator ==(WebEnumAccountingLogDelimiter e1, WebEnumAccountingLogDelimiter e2)
		{
			return (e1.GetType() == e2.GetType() && e1.IntValue == e2.IntValue);
		}
		public static bool operator !=(WebEnumAccountingLogDelimiter e1, WebEnumAccountingLogDelimiter e2)
		{
			return (e1.GetType() != e2.GetType() || e1.IntValue != e2.IntValue);
		}
		public override bool Equals(object obj)
		{
			return this == obj as WebEnumAccountingLogDelimiter;
		}
		public override int GetHashCode()
		{
			return this.IntValue;
		}
		[OnDeserialized]
		internal void OnDeserialized(StreamingContext context)
		{
			if (Enum.IsDefined(typeof(AccountingLogDelimiter), IntValue))
			{
				Value = (AccountingLogDelimiter)Enum.ToObject(typeof(AccountingLogDelimiter), IntValue);
			}
			else
			{
				Value = default(AccountingLogDelimiter);
			}
		}
	}

#if SERVICEDEF
	[DataContract]
#endif
	public partial class WebEnumJobAttributeType
	{
		public WebEnumJobAttributeType(JobAttributeType value)
		{
			Value = value;
			IntValue = (int)value;
		}
#if SERVICEDEF
		[DataMember]
		internal int IntValue { get; set; }
#endif
		public JobAttributeType Value { get; set; }
		public static implicit operator WebEnumJobAttributeType(JobAttributeType value)
		{
			return new WebEnumJobAttributeType(value);
		}
		public static implicit operator JobAttributeType(WebEnumJobAttributeType value)
		{
			return (JobAttributeType)Enum.ToObject(typeof(JobAttributeType), value.IntValue);
		}
		public static bool operator ==(WebEnumJobAttributeType e1, WebEnumJobAttributeType e2)
		{
			return (e1.GetType() == e2.GetType() && e1.IntValue == e2.IntValue);
		}
		public static bool operator !=(WebEnumJobAttributeType e1, WebEnumJobAttributeType e2)
		{
			return (e1.GetType() != e2.GetType() || e1.IntValue != e2.IntValue);
		}
		public override bool Equals(object obj)
		{
			return this == obj as WebEnumJobAttributeType;
		}
		public override int GetHashCode()
		{
			return this.IntValue;
		}
		[OnDeserialized]
		internal void OnDeserialized(StreamingContext context)
		{
			if (Enum.IsDefined(typeof(JobAttributeType), IntValue))
			{
				Value = (JobAttributeType)Enum.ToObject(typeof(JobAttributeType), IntValue);
			}
			else
			{
				Value = default(JobAttributeType);
			}
		}
	}

#if SERVICEDEF
	[DataContract]
#endif
	public partial class WebEnumFilterOperator
	{
		public WebEnumFilterOperator(FilterOperator value)
		{
			Value = value;
			IntValue = (int)value;
		}
#if SERVICEDEF
		[DataMember]
		internal int IntValue { get; set; }
#endif
		public FilterOperator Value { get; set; }
		public static implicit operator WebEnumFilterOperator(FilterOperator value)
		{
			return new WebEnumFilterOperator(value);
		}
		public static implicit operator FilterOperator(WebEnumFilterOperator value)
		{
			return (FilterOperator)Enum.ToObject(typeof(FilterOperator), value.IntValue);
		}
		public static bool operator ==(WebEnumFilterOperator e1, WebEnumFilterOperator e2)
		{
			return (e1.GetType() == e2.GetType() && e1.IntValue == e2.IntValue);
		}
		public static bool operator !=(WebEnumFilterOperator e1, WebEnumFilterOperator e2)
		{
			return (e1.GetType() != e2.GetType() || e1.IntValue != e2.IntValue);
		}
		public override bool Equals(object obj)
		{
			return this == obj as WebEnumFilterOperator;
		}
		public override int GetHashCode()
		{
			return this.IntValue;
		}
		[OnDeserialized]
		internal void OnDeserialized(StreamingContext context)
		{
			if (Enum.IsDefined(typeof(FilterOperator), IntValue))
			{
				Value = (FilterOperator)Enum.ToObject(typeof(FilterOperator), IntValue);
			}
			else
			{
				Value = default(FilterOperator);
			}
		}
	}

#if SERVICEDEF
	[DataContract]
#endif
	public partial class WebEnumObjectState
	{
		public WebEnumObjectState(ObjectState value)
		{
			Value = value;
			IntValue = (int)value;
		}
#if SERVICEDEF
		[DataMember]
		internal int IntValue { get; set; }
#endif
		public ObjectState Value { get; set; }
		public static implicit operator WebEnumObjectState(ObjectState value)
		{
			return new WebEnumObjectState(value);
		}
		public static implicit operator ObjectState(WebEnumObjectState value)
		{
			return (ObjectState)Enum.ToObject(typeof(ObjectState), value.IntValue);
		}
		public static bool operator ==(WebEnumObjectState e1, WebEnumObjectState e2)
		{
			return (e1.GetType() == e2.GetType() && e1.IntValue == e2.IntValue);
		}
		public static bool operator !=(WebEnumObjectState e1, WebEnumObjectState e2)
		{
			return (e1.GetType() != e2.GetType() || e1.IntValue != e2.IntValue);
		}
		public override bool Equals(object obj)
		{
			return this == obj as WebEnumObjectState;
		}
		public override int GetHashCode()
		{
			return this.IntValue;
		}
		[OnDeserialized]
		internal void OnDeserialized(StreamingContext context)
		{
			if (Enum.IsDefined(typeof(ObjectState), IntValue))
			{
				Value = (ObjectState)Enum.ToObject(typeof(ObjectState), IntValue);
			}
			else
			{
				Value = default(ObjectState);
			}
		}
	}

#if SERVICEDEF
	[DataContract]
#endif
	public partial class WebEnumEvent
	{
		public WebEnumEvent(Event value)
		{
			Value = value;
			IntValue = (int)value;
		}
#if SERVICEDEF
		[DataMember]
		internal int IntValue { get; set; }
#endif
		public Event Value { get; set; }
		public static implicit operator WebEnumEvent(Event value)
		{
			return new WebEnumEvent(value);
		}
		public static implicit operator Event(WebEnumEvent value)
		{
			return (Event)Enum.ToObject(typeof(Event), value.IntValue);
		}
		public static bool operator ==(WebEnumEvent e1, WebEnumEvent e2)
		{
			return (e1.GetType() == e2.GetType() && e1.IntValue == e2.IntValue);
		}
		public static bool operator !=(WebEnumEvent e1, WebEnumEvent e2)
		{
			return (e1.GetType() != e2.GetType() || e1.IntValue != e2.IntValue);
		}
		public override bool Equals(object obj)
		{
			return this == obj as WebEnumEvent;
		}
		public override int GetHashCode() 
		{ 
			return this.IntValue; 
		}
		[OnDeserialized]
		internal void OnDeserialized(StreamingContext context)
		{
			if (Enum.IsDefined(typeof(Event), IntValue))
			{
				Value = (Event)Enum.ToObject(typeof(Event), IntValue);
			}
			else
			{
				Value = default(Event);
			}
		}
	}

#if SERVICEDEF
	[DataContract]
#endif
	public partial class WebEnumEventCategoryType
	{
		public WebEnumEventCategoryType(EventCategoryType value)
		{
			Value = value;
			IntValue = (int)value;
		}
#if SERVICEDEF
		[DataMember]
		internal int IntValue { get; set; }
#endif
		public EventCategoryType Value { get; set; }
		public static implicit operator WebEnumEventCategoryType(EventCategoryType value)
		{
			return new WebEnumEventCategoryType(value);
		}
		public static implicit operator EventCategoryType(WebEnumEventCategoryType value)
		{
			return (EventCategoryType)Enum.ToObject(typeof(EventCategoryType), value.IntValue);
		}
		public static bool operator ==(WebEnumEventCategoryType e1, WebEnumEventCategoryType e2)
		{
			return (e1.GetType() == e2.GetType() && e1.IntValue == e2.IntValue);
		}
		public static bool operator !=(WebEnumEventCategoryType e1, WebEnumEventCategoryType e2)
		{
			return (e1.GetType() != e2.GetType() || e1.IntValue != e2.IntValue);
		}
		public override bool Equals(object obj)
		{
			return this == obj as WebEnumEventCategoryType;
		}
		public override int GetHashCode()
		{
			return this.IntValue;
		}
		[OnDeserialized]
		internal void OnDeserialized(StreamingContext context)
		{
			if (Enum.IsDefined(typeof(EventCategoryType), IntValue))
			{
				Value = (EventCategoryType)Enum.ToObject(typeof(EventCategoryType), IntValue);
			}
			else
			{
				Value = default(EventCategoryType);
			}
		}
	}

#if SERVICEDEF
	[DataContract]
#endif
	public partial class WebEnumEventType
	{
		public WebEnumEventType(EventType value)
		{
			Value = value;
			IntValue = (int)value;
		}
#if SERVICEDEF
		[DataMember]
		internal int IntValue { get; set; }
#endif
		public EventType Value { get; set; }
		public static implicit operator WebEnumEventType(EventType value)
		{
			return new WebEnumEventType(value);
		}
		public static implicit operator EventType(WebEnumEventType value)
		{
			return (EventType)Enum.ToObject(typeof(EventType), value.IntValue);
		}
		public static bool operator ==(WebEnumEventType e1, WebEnumEventType e2)
		{
			return (e1.GetType() == e2.GetType() && e1.IntValue == e2.IntValue);
		}
		public static bool operator !=(WebEnumEventType e1, WebEnumEventType e2)
		{
			return (e1.GetType() != e2.GetType() || e1.IntValue != e2.IntValue);
		}
		public override bool Equals(object obj)
		{
			return this == obj as WebEnumEventType;
		}
		public override int GetHashCode()
		{
			return this.IntValue;
		}
		[OnDeserialized]
		internal void OnDeserialized(StreamingContext context)
		{
			if (Enum.IsDefined(typeof(EventType), IntValue))
			{
				Value = (EventType)Enum.ToObject(typeof(EventType), IntValue);
			}
			else
			{
				Value = default(EventType);
			}
		}
	}

#if SERVICEDEF
	[DataContract]
#endif
	public partial class WebEnumPrinterInfoType
	{
		public WebEnumPrinterInfoType(PrinterInfoType value)
		{
			Value = value;
			IntValue = (int)value;
		}
#if SERVICEDEF
		[DataMember]
		internal int IntValue { get; set; }
#endif
		public PrinterInfoType Value { get; set; }
		public static implicit operator WebEnumPrinterInfoType(PrinterInfoType value)
		{
			return new WebEnumPrinterInfoType(value);
		}
		public static implicit operator PrinterInfoType(WebEnumPrinterInfoType value)
		{
			return (PrinterInfoType)Enum.ToObject(typeof(PrinterInfoType), value.IntValue);
		}
		public static bool operator ==(WebEnumPrinterInfoType e1, WebEnumPrinterInfoType e2)
		{
			return (e1.GetType() == e2.GetType() && e1.IntValue == e2.IntValue);
		}
		public static bool operator !=(WebEnumPrinterInfoType e1, WebEnumPrinterInfoType e2)
		{
			return (e1.GetType() != e2.GetType() || e1.IntValue != e2.IntValue);
		}
		public override bool Equals(object obj)
		{
			return this == obj as WebEnumPrinterInfoType;
		}
		public override int GetHashCode()
		{
			return this.IntValue;
		}
		[OnDeserialized]
		internal void OnDeserialized(StreamingContext context)
		{
			if (Enum.IsDefined(typeof(PrinterInfoType), IntValue))
			{
				Value = (PrinterInfoType)Enum.ToObject(typeof(PrinterInfoType), IntValue);
			}
			else
			{
				Value = default(PrinterInfoType);
			}
		}
	}

#if SERVICEDEF
	[DataContract]
#endif
	public partial class WebEnumValidateSelectedJobResultFlags
	{
		public WebEnumValidateSelectedJobResultFlags(ValidateSelectedJobResultFlags value)
		{
			Value = value;
			IntValue = (int)value;
		}
#if SERVICEDEF
		[DataMember]
		internal int IntValue { get; set; }
#endif
		public ValidateSelectedJobResultFlags Value { get; set; }
		public static implicit operator WebEnumValidateSelectedJobResultFlags(ValidateSelectedJobResultFlags value)
		{
			return new WebEnumValidateSelectedJobResultFlags(value);
		}
		public static implicit operator ValidateSelectedJobResultFlags(WebEnumValidateSelectedJobResultFlags value)
		{
			return (ValidateSelectedJobResultFlags)Enum.ToObject(typeof(ValidateSelectedJobResultFlags), value.IntValue);
		}
		public static bool operator ==(WebEnumValidateSelectedJobResultFlags e1, WebEnumValidateSelectedJobResultFlags e2)
		{
			return (e1.GetType() == e2.GetType() && e1.IntValue == e2.IntValue);
		}
		public static bool operator !=(WebEnumValidateSelectedJobResultFlags e1, WebEnumValidateSelectedJobResultFlags e2)
		{
			return (e1.GetType() != e2.GetType() || e1.IntValue != e2.IntValue);
		}
		public override bool Equals(object obj)
		{
			return this == obj as WebEnumValidateSelectedJobResultFlags;
		}
		public override int GetHashCode()
		{
			return this.IntValue;
		}
		[OnDeserialized]
		internal void OnDeserialized(StreamingContext context)
		{
			if (Enum.IsDefined(typeof(ValidateSelectedJobResultFlags), IntValue))
			{
				Value = (ValidateSelectedJobResultFlags)Enum.ToObject(typeof(ValidateSelectedJobResultFlags), IntValue);
			}
			else
			{
				Value = default(ValidateSelectedJobResultFlags);
			}
		}
	}

#if SERVICEDEF
	[DataContract]
#endif
	public partial class WebEnumAttributeCategory
	{
		public WebEnumAttributeCategory(AttributeCategory value)
		{
			Value = value;
			IntValue = (int)value;
		}
#if SERVICEDEF
		[DataMember]
		internal int IntValue { get; set; }
#endif
		public AttributeCategory Value { get; set; }
		public static implicit operator WebEnumAttributeCategory(AttributeCategory value)
		{
			return new WebEnumAttributeCategory(value);
		}
		public static implicit operator AttributeCategory(WebEnumAttributeCategory value)
		{
			return (AttributeCategory)Enum.ToObject(typeof(AttributeCategory), value.IntValue);
		}
		public static bool operator ==(WebEnumAttributeCategory e1, WebEnumAttributeCategory e2)
		{
			return (e1.GetType() == e2.GetType() && e1.IntValue == e2.IntValue);
		}
		public static bool operator !=(WebEnumAttributeCategory e1, WebEnumAttributeCategory e2)
		{
			return (e1.GetType() != e2.GetType() || e1.IntValue != e2.IntValue);
		}
		public override bool Equals(object obj)
		{
			return this == obj as WebEnumAttributeCategory;
		}
		public override int GetHashCode()
		{
			return this.IntValue;
		}
		[OnDeserialized]
		internal void OnDeserialized(StreamingContext context)
		{
			if (Enum.IsDefined(typeof(AttributeCategory), IntValue))
			{
				Value = (AttributeCategory)Enum.ToObject(typeof(AttributeCategory), IntValue);
			}
			else
			{
				Value = default(AttributeCategory);
			}
		}
	}

#if SERVICEDEF
	[DataContract]
#endif
	public partial class WebEnumJobAttributeQueryFlags
	{
		public WebEnumJobAttributeQueryFlags(JobAttributeQueryFlags value)
		{
			Value = value;
			IntValue = (int)value;
		}
#if SERVICEDEF
		[DataMember]
		internal int IntValue { get; set; }
#endif
		public JobAttributeQueryFlags Value { get; set; }
		public static implicit operator WebEnumJobAttributeQueryFlags(JobAttributeQueryFlags value)
		{
			return new WebEnumJobAttributeQueryFlags(value);
		}
		public static implicit operator JobAttributeQueryFlags(WebEnumJobAttributeQueryFlags value)
		{
			return (JobAttributeQueryFlags)Enum.ToObject(typeof(JobAttributeQueryFlags), value.IntValue);
		}
		public static bool operator ==(WebEnumJobAttributeQueryFlags e1, WebEnumJobAttributeQueryFlags e2)
		{
			return (e1.GetType() == e2.GetType() && e1.IntValue == e2.IntValue);
		}
		public static bool operator !=(WebEnumJobAttributeQueryFlags e1, WebEnumJobAttributeQueryFlags e2)
		{
			return (e1.GetType() != e2.GetType() || e1.IntValue != e2.IntValue);
		}
		public override bool Equals(object obj)
		{
			return this == obj as WebEnumJobAttributeQueryFlags;
		}
		public override int GetHashCode()
		{
			return this.IntValue;
		}
		[OnDeserialized]
		internal void OnDeserialized(StreamingContext context)
		{
			if (Enum.IsDefined(typeof(JobAttributeQueryFlags), IntValue))
			{
				Value = (JobAttributeQueryFlags)Enum.ToObject(typeof(JobAttributeQueryFlags), IntValue);
			}
			else
			{
				Value = default(JobAttributeQueryFlags);
			}
		}
	}

#if SERVICEDEF
	[DataContract]
#endif
	public partial class WebEnumAccessFlags
	{
		public WebEnumAccessFlags(AccessFlags value)
		{
			Value = value;
			IntValue = (int)value;
		}
#if SERVICEDEF
		[DataMember]
		internal int IntValue { get; set; }
#endif
		public AccessFlags Value { get; set; }
		public static implicit operator WebEnumAccessFlags(AccessFlags value)
		{
			return new WebEnumAccessFlags(value);
		}
		public static implicit operator AccessFlags(WebEnumAccessFlags value)
		{
			return (AccessFlags)Enum.ToObject(typeof(AccessFlags), value.IntValue);
		}
		public static bool operator ==(WebEnumAccessFlags e1, WebEnumAccessFlags e2)
		{
			return (e1.GetType() == e2.GetType() && e1.IntValue == e2.IntValue);
		}
		public static bool operator !=(WebEnumAccessFlags e1, WebEnumAccessFlags e2)
		{
			return (e1.GetType() != e2.GetType() || e1.IntValue != e2.IntValue);
		}
		public override bool Equals(object obj)
		{
			return this == obj as WebEnumAccessFlags;
		}
		public override int GetHashCode()
		{
			return this.IntValue;
		}
		[OnDeserialized]
		internal void OnDeserialized(StreamingContext context)
		{
			if (Enum.IsDefined(typeof(AccessFlags), IntValue))
			{
				Value = (AccessFlags)Enum.ToObject(typeof(AccessFlags), IntValue);
			}
			else
			{
				Value = default(AccessFlags);
			}
		}
	}

#if SERVICEDEF
	[DataContract]
#endif
	public partial class WebEnumManagementFlags
	{
		public WebEnumManagementFlags(ManagementFlags value)
		{
			Value = value;
			IntValue = (int)value;
		}
#if SERVICEDEF
		[DataMember]
		internal int IntValue { get; set; }
#endif
		public ManagementFlags Value { get; set; }
		public static implicit operator WebEnumManagementFlags(ManagementFlags value)
		{
			return new WebEnumManagementFlags(value);
		}
		public static implicit operator ManagementFlags(WebEnumManagementFlags value)
		{
			return (ManagementFlags)Enum.ToObject(typeof(ManagementFlags), value.IntValue);
		}
		public static bool operator ==(WebEnumManagementFlags e1, WebEnumManagementFlags e2)
		{
			return (e1.GetType() == e2.GetType() && e1.IntValue == e2.IntValue);
		}
		public static bool operator !=(WebEnumManagementFlags e1, WebEnumManagementFlags e2)
		{
			return (e1.GetType() != e2.GetType() || e1.IntValue != e2.IntValue);
		}
		public override bool Equals(object obj)
		{
			return this == obj as WebEnumManagementFlags;
		}
		public override int GetHashCode()
		{
			return this.IntValue;
		}
		[OnDeserialized]
		internal void OnDeserialized(StreamingContext context)
		{
			if (Enum.IsDefined(typeof(ManagementFlags), IntValue))
			{
				Value = (ManagementFlags)Enum.ToObject(typeof(ManagementFlags), IntValue);
			}
			else
			{
				Value = default(ManagementFlags);
			}
		}
	}

#if SERVICEDEF
	[DataContract]
#endif
	public partial class WebEnumJobAttribute
	{
		public WebEnumJobAttribute(JobAttribute value)
		{
			Value = value;
			IntValue = (int)value;
		}
#if SERVICEDEF
		[DataMember]
		internal int IntValue { get; set; }
#endif
		public JobAttribute Value { get; set; }
		public static implicit operator WebEnumJobAttribute(JobAttribute value)
		{
			return new WebEnumJobAttribute(value);
		}
		public static implicit operator JobAttribute(WebEnumJobAttribute value)
		{
			return (JobAttribute)Enum.ToObject(typeof(JobAttribute), value.IntValue);
		}
		public static bool operator ==(WebEnumJobAttribute e1, WebEnumJobAttribute e2)
		{
			return (e1.GetType() == e2.GetType() && e1.IntValue == e2.IntValue);
		}
		public static bool operator !=(WebEnumJobAttribute e1, WebEnumJobAttribute e2)
		{
			return (e1.GetType() != e2.GetType() || e1.IntValue != e2.IntValue);
		}
		public override bool Equals(object obj)
		{
			return this == obj as WebEnumJobAttribute;
		}
		public override int GetHashCode()
		{
			return this.IntValue;
		}
		[OnDeserialized]
		internal void OnDeserialized(StreamingContext context)
		{
			if (Enum.IsDefined(typeof(JobAttribute), IntValue))
			{
				Value = (JobAttribute)Enum.ToObject(typeof(JobAttribute), IntValue);
			}
			else
			{
				Value = default(JobAttribute);
			}
		}
	}
	
#if SERVICEDEF
	[DataContract]
#endif
	public partial class WebEnumApplicationResourceType
	{
		public WebEnumApplicationResourceType(ApplicationResourceType value)
		{
			Value = value;
			IntValue = (int)value;
		}
#if SERVICEDEF
		[DataMember]
		internal int IntValue { get; set; }
#endif
		public ApplicationResourceType Value { get; set; }
		public static implicit operator WebEnumApplicationResourceType(ApplicationResourceType value)
		{
			return new WebEnumApplicationResourceType(value);
		}
		public static implicit operator ApplicationResourceType(WebEnumApplicationResourceType value)
		{
			return (ApplicationResourceType)Enum.ToObject(typeof(ApplicationResourceType), value.IntValue);
		}
		public static bool operator ==(WebEnumApplicationResourceType e1, WebEnumApplicationResourceType e2)
		{
			return (e1.GetType() == e2.GetType() && e1.IntValue == e2.IntValue);
		}
		public static bool operator !=(WebEnumApplicationResourceType e1, WebEnumApplicationResourceType e2)
		{
			return (e1.GetType() != e2.GetType() || e1.IntValue != e2.IntValue);
		}
		public override bool Equals(object obj)
		{
			return this == obj as WebEnumApplicationResourceType;
		}
		public override int GetHashCode()
		{
			return this.IntValue;
		}
		[OnDeserialized]
		internal void OnDeserialized(StreamingContext context)
		{
			if (Enum.IsDefined(typeof(ApplicationResourceType), IntValue))
			{
				Value = (ApplicationResourceType)Enum.ToObject(typeof(ApplicationResourceType), IntValue);
			}
			else
			{
				Value = default(ApplicationResourceType);
			}
		}
	}

#if SERVICEDEF
	[DataContract]
#endif
	public partial class WebEnumSiteStatus
	{
		public WebEnumSiteStatus(SiteStatus value)
		{
			Value = value;
			IntValue = (int)value;
		}
#if SERVICEDEF
		[DataMember]
		internal int IntValue { get; set; }
#endif
		public SiteStatus Value { get; set; }
		public static implicit operator WebEnumSiteStatus(SiteStatus value)
		{
			return new WebEnumSiteStatus(value);
		}
		public static implicit operator SiteStatus(WebEnumSiteStatus value)
		{
			return (SiteStatus)Enum.ToObject(typeof(SiteStatus), value.IntValue);
		}
		public static bool operator ==(WebEnumSiteStatus e1, WebEnumSiteStatus e2)
		{
			return (e1.GetType() == e2.GetType() && e1.IntValue == e2.IntValue);
		}
		public static bool operator !=(WebEnumSiteStatus e1, WebEnumSiteStatus e2)
		{
			return (e1.GetType() != e2.GetType() || e1.IntValue != e2.IntValue);
		}
		public override bool Equals(object obj)
		{
			return this == obj as WebEnumSiteStatus;
		}
		public override int GetHashCode()
		{
			return this.IntValue;
		}
		[OnDeserialized]
		internal void OnDeserialized(StreamingContext context)
		{
			if (Enum.IsDefined(typeof(SiteStatus), IntValue))
			{
				Value = (SiteStatus)Enum.ToObject(typeof(SiteStatus), IntValue);
			}
			else
			{
				Value = default(SiteStatus);
			}
		}
	}
}
