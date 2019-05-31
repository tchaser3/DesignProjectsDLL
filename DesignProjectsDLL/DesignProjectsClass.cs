/* Title:           Design Projects Class
 * Date:            1-16-19
 * Author:          Terry Holmes
 * 
 * Description:     This class is used for the Design Projects information */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace DesignProjectsDLL
{
    public class DesignProjectsClass
    {
        //setting up the classes
        EventLogClass TheEventLogClass = new EventLogClass();

        DesignProjectsDataSet aDesignProjectsDataSet;
        DesignProjectsDataSetTableAdapters.designprojectsTableAdapter aDesignProjectsTableAdapter;

        InsertDesignProjectEntryTableAdapters.QueriesTableAdapter aInsertDesignProjectTableAdapter;

        UpdateDesignJobStatusTableAdapters.QueriesTableAdapter aUpdateDesignJobStatusTableAdapter;

        UpdateDesignProjectSurveyInvoiceEntryTableAdapters.QueriesTableAdapter aUpdateDesignProjectsSurveyInvoiceTableAdapter;

        UpdateDesignProjectBJCInvoiceTableAdapters.QueriesTableAdapter aUpdateDesignProjectBJCInvoiceTableAdapter;

        CloseDesignProjectEntryTableAdapters.QueriesTableAdapter aCloseDesignProjectTableAdapter;

        FindOpenDesignProjectsDataSet aFindOpenDesignProjectsDataSet;
        FindOpenDesignProjectsDataSetTableAdapters.FindOpenDesignProjectsTableAdapter aFindOpenDesignProjectsTableAdapter;

        FindOpenDesignProjectsByLocationDataSet aFindOpenDesignProjectsByLocationDataSet;
        FindOpenDesignProjectsByLocationDataSetTableAdapters.FindOpenDesignProjectsByLocationTableAdapter aFindOpenDesignProjectsByLocationTableAdapter;

        FindDesignProjectsByAssignedProjectIDDataSet aFindDesignProjectsByAssignedProjectIDDataSet;
        FindDesignProjectsByAssignedProjectIDDataSetTableAdapters.FindDesignProjectsByAssignedProjectIDTableAdapter aFindDesignProjectsByAssignedProjectIDTableAdapter;

        FindDesignProjectsByAddressDataSet aFindDesignProjectsByAddressDataSet;
        FindDesignProjectsByAddressDataSetTableAdapters.FindDesignProjectsByAddessTableAdapter aFindDesignProjectsByAddressTableAdapter;

        FindDesignProjectsByDateRangeDataSet aFindDesignProjectsByDateRangeDataSet;
        FindDesignProjectsByDateRangeDataSetTableAdapters.FindDesignProjectsByDateRangeTableAdapter aFindDesignProjectsByDateRangeTableAdapter;

        FindDesignProjectsByJobStatusDataSet aFindDesignProjectsByJobStatusDataSet;
        FindDesignProjectsByJobStatusDataSetTableAdapters.FindDesignProjectsByJobStatusTableAdapter aFindDesignProjectsByJobStatusTableAdapter;

        FindDesignProjectsByLocationDataSet aFindDesignProjectsByLocationDataSet;
        FindDesignProjectsByLocationDataSetTableAdapters.FindDesignProjectsByLocationTableAdapter aFindDesignProjectsByLocationTableAdapter;

        FindOpenDesignProjectLocationDataSet aFindOpenDesignProjectLocationDataSet;
        FindOpenDesignProjectLocationDataSetTableAdapters.FindOpenDesignProjectLocationsTableAdapter aFindOpenDesignProjectLocationTableAdapters;

        UpdateDesignProjectStateZipEntryTableAdapters.QueriesTableAdapter aUpdateDesignProjectStateZipTableAdapter;

        public bool UpdateDesignProjectStateZip(int intTransactionID, string strState, string strZipCode)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateDesignProjectStateZipTableAdapter = new UpdateDesignProjectStateZipEntryTableAdapters.QueriesTableAdapter();
                aUpdateDesignProjectStateZipTableAdapter.UpdateDesignProjectStateZip(intTransactionID, strState, strZipCode);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Project Class // Update Design Project State Zip " + Ex.Message);
            }

            return blnFatalError;
        }
        public FindOpenDesignProjectLocationDataSet FindOpenDesignProjectLocation()
        {
            try
            {
                aFindOpenDesignProjectLocationDataSet = new FindOpenDesignProjectLocationDataSet();
                aFindOpenDesignProjectLocationTableAdapters = new FindOpenDesignProjectLocationDataSetTableAdapters.FindOpenDesignProjectLocationsTableAdapter();
                aFindOpenDesignProjectLocationTableAdapters.Fill(aFindOpenDesignProjectLocationDataSet.FindOpenDesignProjectLocations);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Projects Class // Find Open Design Project Location " + Ex.Message);
            }

            return aFindOpenDesignProjectLocationDataSet;
        }
        public FindDesignProjectsByLocationDataSet FindDesignProjectsByLocation(int intOfficeID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindDesignProjectsByLocationDataSet = new FindDesignProjectsByLocationDataSet();
                aFindDesignProjectsByLocationTableAdapter = new FindDesignProjectsByLocationDataSetTableAdapters.FindDesignProjectsByLocationTableAdapter();
                aFindDesignProjectsByLocationTableAdapter.Fill(aFindDesignProjectsByLocationDataSet.FindDesignProjectsByLocation, intOfficeID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Projects Class // Find Design Projects By Location " + Ex.Message);
            }

            return aFindDesignProjectsByLocationDataSet;
        }
        public FindDesignProjectsByJobStatusDataSet FindDesignProjectsByJobStatus(string strJobStatus)
        {
            try
            {
                aFindDesignProjectsByJobStatusDataSet = new FindDesignProjectsByJobStatusDataSet();
                aFindDesignProjectsByJobStatusTableAdapter = new FindDesignProjectsByJobStatusDataSetTableAdapters.FindDesignProjectsByJobStatusTableAdapter();
                aFindDesignProjectsByJobStatusTableAdapter.Fill(aFindDesignProjectsByJobStatusDataSet.FindDesignProjectsByJobStatus, strJobStatus);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Projects Class // Find Design Projects By Job Status " + Ex.Message);
            }

            return aFindDesignProjectsByJobStatusDataSet;
        }
        public FindDesignProjectsByDateRangeDataSet FindDesignProjectsByDateRange(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindDesignProjectsByDateRangeDataSet = new FindDesignProjectsByDateRangeDataSet();
                aFindDesignProjectsByDateRangeTableAdapter = new FindDesignProjectsByDateRangeDataSetTableAdapters.FindDesignProjectsByDateRangeTableAdapter();
                aFindDesignProjectsByDateRangeTableAdapter.Fill(aFindDesignProjectsByDateRangeDataSet.FindDesignProjectsByDateRange, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Find Design Projects By Date Range " + Ex.Message);
            }

            return aFindDesignProjectsByDateRangeDataSet;
        }
        public  FindDesignProjectsByAddressDataSet FindDesignProjectsByAddress(string strAddress)
        {
            try
            {
                aFindDesignProjectsByAddressDataSet = new FindDesignProjectsByAddressDataSet();
                aFindDesignProjectsByAddressTableAdapter = new FindDesignProjectsByAddressDataSetTableAdapters.FindDesignProjectsByAddessTableAdapter();
                aFindDesignProjectsByAddressTableAdapter.Fill(aFindDesignProjectsByAddressDataSet.FindDesignProjectsByAddess, strAddress);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Project Class // Find Design Projects By Address " + Ex.Message);
            }

            return aFindDesignProjectsByAddressDataSet;
        }
        public FindDesignProjectsByAssignedProjectIDDataSet FindDesignProjectsByAssignedProjectID(string strAssignedProjectID)
        {
            try
            {
                aFindDesignProjectsByAssignedProjectIDDataSet = new FindDesignProjectsByAssignedProjectIDDataSet();
                aFindDesignProjectsByAssignedProjectIDTableAdapter = new FindDesignProjectsByAssignedProjectIDDataSetTableAdapters.FindDesignProjectsByAssignedProjectIDTableAdapter();
                aFindDesignProjectsByAssignedProjectIDTableAdapter.Fill(aFindDesignProjectsByAssignedProjectIDDataSet.FindDesignProjectsByAssignedProjectID, strAssignedProjectID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Projects Class // Find Design Projects By Assigned Project ID " + Ex.Message);
            }

            return aFindDesignProjectsByAssignedProjectIDDataSet;
        }
        public FindOpenDesignProjectsByLocationDataSet FindOpenDesignProjectsByLocation(int intOfficeID)
        {
            try
            {
                aFindOpenDesignProjectsByLocationDataSet = new FindOpenDesignProjectsByLocationDataSet();
                aFindOpenDesignProjectsByLocationTableAdapter = new FindOpenDesignProjectsByLocationDataSetTableAdapters.FindOpenDesignProjectsByLocationTableAdapter();
                aFindOpenDesignProjectsByLocationTableAdapter.Fill(aFindOpenDesignProjectsByLocationDataSet.FindOpenDesignProjectsByLocation, intOfficeID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Projects Class // Find Open Design Projects By Location " + Ex.Message);
            }

            return aFindOpenDesignProjectsByLocationDataSet;
        }
        public FindOpenDesignProjectsDataSet FindOpenDesignProjects()
        {
            try
            {
                aFindOpenDesignProjectsDataSet = new FindOpenDesignProjectsDataSet();
                aFindOpenDesignProjectsTableAdapter = new FindOpenDesignProjectsDataSetTableAdapters.FindOpenDesignProjectsTableAdapter();
                aFindOpenDesignProjectsTableAdapter.Fill(aFindOpenDesignProjectsDataSet.FindOpenDesignProjects);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Project Class // Find Open Design Projects " + Ex.Message);
            }

            return aFindOpenDesignProjectsDataSet;
        }
        public bool CloseDesignProject(int intTransactionID, DateTime datCompleteDate)
        {
            bool blnFatalError = false;

            try
            {
                aCloseDesignProjectTableAdapter = new CloseDesignProjectEntryTableAdapters.QueriesTableAdapter();
                aCloseDesignProjectTableAdapter.CloseDesignProject(intTransactionID, datCompleteDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Project Class // Close Design Project " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool UpdateDesignProjectBJCInvoice(int intTransactionID, Decimal decBJCInvoice)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateDesignProjectBJCInvoiceTableAdapter = new UpdateDesignProjectBJCInvoiceTableAdapters.QueriesTableAdapter();
                aUpdateDesignProjectBJCInvoiceTableAdapter.UpdateDesignProjectBJCInvoice(intTransactionID, decBJCInvoice);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Project Class // Update Design Project BJC Invoice " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }

        public bool UpdateDesignProjectSurveyInvoice(int intTransactionID, decimal decSurveyInvoice)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateDesignProjectsSurveyInvoiceTableAdapter = new UpdateDesignProjectSurveyInvoiceEntryTableAdapters.QueriesTableAdapter();
                aUpdateDesignProjectsSurveyInvoiceTableAdapter.UpdateDesignProjectSurveyInvoice(intTransactionID, decSurveyInvoice);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Projects Class // Update Design Projects Survey Invoice " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool UpdateDesignProjectJobStatus(int intTransactionID, string strJobStatus)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateDesignJobStatusTableAdapter = new UpdateDesignJobStatusTableAdapters.QueriesTableAdapter();
                aUpdateDesignJobStatusTableAdapter.UpdateDesignJobStatus(intTransactionID, strJobStatus);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Projects Class // Update Design Project Job Status " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool InsertDesignProject(int intProjectID, string strProjectAddress, string strCity, int intOfficeID, DateTime datDateReceived, int intJobTypeID, string strCoordinator, string strProjectNotes, string strState, string strZipCode)
        {
            bool blnFatalError = false;

            try
            {
                aInsertDesignProjectTableAdapter = new InsertDesignProjectEntryTableAdapters.QueriesTableAdapter();
                aInsertDesignProjectTableAdapter.InsertDesignProject(intProjectID, strProjectAddress, strCity, intOfficeID, datDateReceived, intJobTypeID, strCoordinator, strProjectNotes, strState, strZipCode);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Projects Class // Insert Design Project " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public DesignProjectsDataSet GetDesignProjectsInfo()
        {
            try
            {
                aDesignProjectsDataSet = new DesignProjectsDataSet();
                aDesignProjectsTableAdapter = new DesignProjectsDataSetTableAdapters.designprojectsTableAdapter();
                aDesignProjectsTableAdapter.Fill(aDesignProjectsDataSet.designprojects);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Project Class // Get Design Projects Info " + Ex.Message);
            }

            return aDesignProjectsDataSet;
        }
        public void UpdateDesignProjectsDB(DesignProjectsDataSet aDesignProjectsDataSet)
        {
            try
            {
                aDesignProjectsTableAdapter = new DesignProjectsDataSetTableAdapters.designprojectsTableAdapter();
                aDesignProjectsTableAdapter.Update(aDesignProjectsDataSet.designprojects);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Project Class // Update Design Projects DB " + Ex.Message);
            }
        }
    }
}
