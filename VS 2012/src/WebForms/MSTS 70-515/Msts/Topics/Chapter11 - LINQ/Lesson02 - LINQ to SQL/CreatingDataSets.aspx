﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Topics/Chapter02/Lesson01 - MasterPages/ClassicMaster.Master" AutoEventWireup="true" CodeBehind="CreatingDataSets.aspx.cs" Inherits="Msts.Topics.Chapter11___LINQ.Lesson02___LINQ_to_SQL.CreatingDataSets" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>
        Creating a dataset manually
    </h1>
    <ajaxToolkit:Accordion runat="server" ID="accordion" SelectedIndex="0"
        HeaderCssClass="accordionHeader"
    HeaderSelectedCssClass="accordionHeaderSelected"
    ContentCssClass="accordionContent"
    AutoSize="None"
    FadeTransitions="true"
    TransitionDuration="250"
    FramesPerSecond="40"
    RequireOpenedPane="false"
    SuppressHeaderPostbacks="true">
        <ContentTemplate>
            mmm content?
        </ContentTemplate>
        <HeaderTemplate>
            Woops
        </HeaderTemplate>
        <Panes>
            <ajaxToolkit:AccordionPane runat="server" ID="pane1"
                HeaderCssClass="accordionHeader"
            HeaderSelectedCssClass="accordionHeaderSelected"
            ContentCssClass="accordionContent">
                <Header>
                    Header 1
                </Header>
                <Content>
                    <asp:GridView runat="server" ID="gv" AutoGenerateColumns="false" DataKeyNames="job_id">
                        <Columns>
                            <asp:BoundField DataField="job_id" HeaderText="Job ID" ItemStyle-Width="120px" />
                            <asp:BoundField DataField="job_desc" HeaderText="Job Description" />
                        </Columns>
                    </asp:GridView>
                </Content>
            </ajaxToolkit:AccordionPane>
        </Panes>
    </ajaxToolkit:Accordion>
</asp:Content>
