﻿using Msts.GenericModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Msts.Topics.Chapter09___Scripts.Lesson03___JQuery._10_For_AJAX
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmployeesServiceWCF" in both code and config file together.
    [ServiceContract]
    public interface IEmployeesServiceWCF
    {
        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        List<Employee> GetEmployees(int page);

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        List<Job> GetJobs();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        List<Employee> GetEmployeeByJob(short jobID);
    }
}
