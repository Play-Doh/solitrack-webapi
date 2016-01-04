# solitrack-webapi
This is an asp.net MVC 5 web-api using entity framework to connect to Solitrack and return JSON via HTTP

This is my first attempt at a web api. It is intended to allow 

1.) the use of asp.net MVC routing to allow you to search for a job in the solitrack database

2.) the use of webhooks to listen and wait for a new hook and respond in a way you want to, 
  in this case, write out a file with log information
  
3.) a way for non-windows or non-available (meaning, the Soltrack server is not allowed to communicate externally) systems 
  to either lookup jobs and get a JSON return or when jobs complete or error to have a file delivered with information
  to respond to in a common way (JSON).

At some point I will upgrade this to asp.net 5 but I am not sure I can right now because I think from
what I read you need an internet connection to use the functionality, I wrote this for a non-internet connected
server set. asp.net 5 is quite different.

In order to use this you need to 

1.) add the DB info to the SQL connection string (found in the Web.config file) 
<add name="stdbContext" connectionString="data source=DBSERVERNAME;initial catalog=DBNAME;integrated security=True;
  multipleactiveresultsets=True;application name=EntityFramework" providerName="System.Data.SqlClient"/>

The items to change here are DBSERVERNAME with your database server name and DBNAME with the name of the 
database you want to connect to

2.) in JobController.cs the name of the Solitrack Server needs to be updated
SOLitrackApplicationAPI appAPI = new SOLitrackApplicationAPI("SOLITRACK SERVER NAME");

Once complete, you should be able to run this web service and get back JSON objects with job information in them.
It will only return 15 as you might note, to keep the results down.

I developed this with Visual Studio 2015 Community Edition and IIS 7.5 on Windows 7 and 2008 R2 Server.

I realize that there is a lot of extraneous code here, I used entity framework and it scaffolded out more than I needed. 
I will clean that up in the upgrade to asp.net 5. I am not going to develop this further in 4.5.
