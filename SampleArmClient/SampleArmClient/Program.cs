using System;
using System.Collections.Generic;
using System.Text;
using SampleARMClient.ARM;
using System.Net;
using System.IO;
using System.Threading;
using ServiceReference1;

namespace SampleARMClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ArmServiceImplService armService = new ArmServiceImplService();
            // TODO: Replace with live server URL when ready
            armService.Url = "http://localhost:8081/ARM/ARM/";

            NetworkCredential credentials = new NetworkCredential();
            // TODO: Replace with userid/password issued by HUD for HCS system when ready
            credentials.UserName = "gcornejo";
            credentials.Password = "gabriel123";
            armService.Credentials = credentials;

            doPing(armService);
            doGetReference(armService);
            postSubmissionResponse submissionId = doPostAgencyData(armService);
            while (doGetSubmissionInfo(armService, submissionId) != true)
            {
                // sleep for 60 seconds before checking agin.
                Thread.Sleep(60000);
            }
        }

        private static void doGetReference(ArmServiceImplService armService)
        {
            getReference getReference = new getReference();
            // TODO: Replace 80000 with your agency HCS id.
            getReference.agcHcsId = 80000;
            getReference.referenceId = 0;
            referenceItem[] referenceItems = armService.getReference(getReference);
            foreach (referenceItem referenceItem in referenceItems)
            {
                Console.WriteLine(referenceItem.id);
                Console.WriteLine(referenceItem.name);
                Console.WriteLine(referenceItem.longDesc);
                Console.WriteLine(referenceItem.shortDesc);
            }
        }

        private static void doPing(ArmServiceImplService armService)
        {
            ping pingIn = new ping();
            // TODO: Replace 80000 with your agency HCS id.
            pingIn.agcHcsId = 80000;
            string pingString = armService.ping(pingIn);
            Console.WriteLine(pingString);
        }

        private static postSubmissionResponse doPostAgencyData(ArmServiceImplService armService)
        {
            postAgencyData postAgencyData = new postAgencyData();
            submissionHeader50 header = new submissionHeader50();
            // TODO: Replace 80000 with your agency HCS id.
            header.agcHcsId = 80000;
            header.agcName = "TEST AGENCY";
            // TODO: Replace 8 with your CMS vendor id issued to you by ARM Development Team.
            header.systemName = 8;
            header.subFlag = 0;
            postAgencyData.submissionHeader50 = header;

            // TODO: Replace the test databag with a valid databag of your own
            FileStream file = new FileStream("C:\Users\GabrielC\Documents\GitHub\arm\src\main\resources\gov\hud\arm\databag\testAgencyProfileData.xml", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(file);
            string str = sr.ReadToEnd();

            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            postAgencyData.submissionData = encoding.GetBytes(str);

            postSubmissionResponse submissionId = armService.postAgencyData(postAgencyData);
            Console.WriteLine("Submitted Data returned id : " + submissionId);
            return submissionId;
        }

        private static Boolean doGetSubmissionInfo(ArmServiceImplService armService,
            postSubmissionResponse postSubmissionResponse)
        {
            getSubmissionInfo getSubmissionInfo = new getSubmissionInfo();
            // TODO: Replace 80000 with your agency HCS id.
            getSubmissionInfo.agcHcsId = 80000;
            getSubmissionInfo.submissionId = postSubmissionResponse.submissionId;
            getSubmissionInfoResponse response = armService.getSubmissionInfo(getSubmissionInfo);
            Console.WriteLine("SubmissionInfo Status Date = " + response.statusDate);
            Console.WriteLine("SubmissionInfo Status Message = " + response.statusMessage);
            // if Done or Error returned, then return true to stop polling server.
            if (response.statusMessage.Equals("DONE") || response.statusMessage.Contains("ERROR"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}