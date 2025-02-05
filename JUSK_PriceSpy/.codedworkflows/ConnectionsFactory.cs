using UiPath.CodedWorkflows;
using System;

namespace JUSK_PriceSpy
{
    public class GoogleDocsFactory
    {
        public GoogleDocsFactory(ICodedWorkflowsServiceContainer resolver)
        {
        }
    }

    public class DriveFactory
    {
        public UiPath.GSuite.Activities.Api.DriveConnection My_Workspace_stanchyyy_gmail_com { get; set; }

        public DriveFactory(ICodedWorkflowsServiceContainer resolver)
        {
            My_Workspace_stanchyyy_gmail_com = new UiPath.GSuite.Activities.Api.DriveConnection("1c43eeff-3628-4d7c-9fe2-3e6ba71b6de9", resolver);
        }
    }

    public class GmailFactory
    {
        public UiPath.GSuite.Activities.Api.GmailConnection My_Workspace_stanchyyy_gmail_com { get; set; }

        public GmailFactory(ICodedWorkflowsServiceContainer resolver)
        {
            My_Workspace_stanchyyy_gmail_com = new UiPath.GSuite.Activities.Api.GmailConnection("755a135a-9c27-4b7f-b7a7-c0c7cf684ceb", resolver);
        }
    }

    public class GoogleSheetsFactory
    {
        public UiPath.GSuite.Activities.Api.SheetsConnection My_Workspace_stanchyyy_gmail_com { get; set; }

        public GoogleSheetsFactory(ICodedWorkflowsServiceContainer resolver)
        {
            My_Workspace_stanchyyy_gmail_com = new UiPath.GSuite.Activities.Api.SheetsConnection("4c11a5f3-8709-4894-bdd3-76eab232d0b9", resolver);
        }
    }
}