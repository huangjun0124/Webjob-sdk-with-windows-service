You can find the original solution here:Simple Azure Website with WebJobs using the WebJobs SDK   
https://code.msdn.microsoft.com/Simple-Azure-Website-with-b4391eeb/   
   
This project adds features:   
	1.Change to use Local database and Local Azure storage emulator   
	2.Add a console application(ConsoleApp1) to wrap code with WebJobs   
	3.Add a Windows Service Application(ContosoAdsService) to also wrap code with WebJobs   
   
   
   
To use WebJobs in your own new application, search for WebJobs in NuGet and install   
To make WebJobs know your methods, you should make Functions class public    
   
   
To run:   
	1.Start WebSite: Debug ContosoAdsWeb in VS, or deploy it to IIS   
	2.Start job:   
	you can   
		run console application ConsoleApp1 or ContosoAdsWebJob (ContosoAdsWebJob is actually intended for Azure delpoy)   
	or   
		deploy windows service ContosoAdsService, then in VS->Debug->Attach to process   
   
For Windows Service develop in C#, refer to file Windows Service.docx in folder   
For information on how to deploy website to IIS, refer to deploy asp net to iis.mp4 file   
   
   
Need to install Azure storage emulator and start it   
Need to install Azure storage explorer to view local and remote azure storage(queue, blob, tables)   
Need to install SQL Server express and management studio, configure see sqlservermanager13.msc      

	
	
	
	
