﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CallingSimpleWcfDataServiceInCodeBehind.aspx.cs" Inherits="CQRS_SimpleQuery01.CallingSimpleWcfDataServiceInCodeBehind" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView runat="server" ID="gv"
            SelectMethod="gv_GetData"
            ItemType="QueryRepository.JobDto, QueryRepository"
            AllowPaging="true"
            PageSize="3">

        </asp:GridView>
    </div>
    </form>
</body>
</html>
