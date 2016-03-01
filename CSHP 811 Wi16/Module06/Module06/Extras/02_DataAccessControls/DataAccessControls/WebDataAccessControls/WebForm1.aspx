<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebDataAccessControls.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NWindConnectionString %>"
        ProviderName="<%$ ConnectionStrings:NWindConnectionString.ProviderName %>" SelectCommand="SELECT [RegionID], [RegionDescription] FROM [Region]"
        ConflictDetection="CompareAllValues" DeleteCommand="DELETE FROM [Region] WHERE [RegionID] = ? AND [RegionDescription] = ?"
        InsertCommand="INSERT INTO [Region] ([RegionID], [RegionDescription]) VALUES (?, ?)"
        OldValuesParameterFormatString="original_{0}" UpdateCommand="UPDATE [Region] SET [RegionDescription] = ? WHERE [RegionID] = ? AND [RegionDescription] = ?">
        <DeleteParameters>
            <asp:Parameter Name="original_RegionID" Type="Int32" />
            <asp:Parameter Name="original_RegionDescription" Type="String" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="RegionID" Type="Int32" />
            <asp:Parameter Name="RegionDescription" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="RegionDescription" Type="String" />
            <asp:Parameter Name="original_RegionID" Type="Int32" />
            <asp:Parameter Name="original_RegionDescription" Type="String" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <div>
        <asp:Panel ID="Panel1" runat="server" Style="position: relative; top: 5px; left: 100px;
            height: 229px; width: 403px;" BorderStyle="Solid" BorderWidth="1px">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="RegionID"
                DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                    <asp:BoundField DataField="RegionID" HeaderText="RegionID" ReadOnly="True" SortExpression="RegionID" />
                    <asp:BoundField DataField="RegionDescription" HeaderText="RegionDescription" SortExpression="RegionDescription" />
                </Columns>
            </asp:GridView>
            &nbsp;<p>
                No button is needed to force the update, since Update and Delete<br />
                automatically force a postback to the Web Server. </p>
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" Style="position: relative; top: -231px; left: 519px;
            height: 230px; width: 321px;" BorderColor="Black" BorderStyle="Solid" 
            BorderWidth="1px">
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConflictDetection="CompareAllValues"
                ConnectionString="<%$ ConnectionStrings:NWindConnectionString %>" DeleteCommand="DELETE FROM [Region] WHERE [RegionID] = ? AND [RegionDescription] = ?"
                InsertCommand="INSERT INTO [Region] ([RegionID], [RegionDescription]) VALUES (?, ?)"
                OldValuesParameterFormatString="original_{0}" ProviderName="<%$ ConnectionStrings:NWindConnectionString.ProviderName %>"
                SelectCommand="SELECT [RegionID], [RegionDescription] FROM [Region] WHERE ([RegionID] = ?)"
                UpdateCommand="UPDATE [Region] SET [RegionDescription] = ? WHERE [RegionID] = ? AND [RegionDescription] = ?">
                <DeleteParameters>
                    <asp:Parameter Name="original_RegionID" Type="Int32" />
                    <asp:Parameter Name="original_RegionDescription" Type="String" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="RegionID" Type="Int32" />
                    <asp:Parameter Name="RegionDescription" Type="String" />
                </InsertParameters>
                <SelectParameters>
                    <asp:ControlParameter ControlID="GridView1" Name="RegionID" PropertyName="SelectedValue"
                        Type="Int32" />
                </SelectParameters>
                <UpdateParameters>
                    <asp:Parameter Name="RegionDescription" Type="String" />
                    <asp:Parameter Name="original_RegionID" Type="Int32" />
                    <asp:Parameter Name="original_RegionDescription" Type="String" />
                </UpdateParameters>
            </asp:SqlDataSource>
            <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="RegionID"
                DataSourceID="SqlDataSource2" Height="50px" Width="125px">
                <Fields>
                    <asp:BoundField DataField="RegionID" HeaderText="RegionID" ReadOnly="True" SortExpression="RegionID" />
                    <asp:BoundField DataField="RegionDescription" HeaderText="RegionDescription" SortExpression="RegionDescription" />
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
                </Fields>
            </asp:DetailsView>

            But, to Get new data from the database you need to force it to redo the data 
            binding!<br />
            <br />
            &nbsp;&nbsp;<asp:Button ID="ButtonForceDataBinding1" runat="server" 
                OnClick="ButtonForceDataBinding_Click" Text="Force Databinding" Width="139px" />
            <br />

        </asp:Panel>
        <asp:Panel ID="Panel3" runat="server" Style="position: relative; top: -193px; left: 99px;
            height: 186px; width: 560px;" BorderStyle="Solid" BorderWidth="1px">
            &nbsp;<asp:DropDownList ID="DropDownList1" runat="server" 
                DataSourceID="SqlDataSource1" DataTextField="RegionDescription" 
                DataValueField="RegionID">
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:ListBox 
                ID="ListBox1" runat="server" DataSourceID="SqlDataSource1" 
                DataTextField="RegionDescription" DataValueField="RegionID" 
                DataMember="DefaultView"></asp:ListBox>
            &nbsp;&nbsp;<br /> The SelectedValue property of both&nbsp; DropDownBoxs and &nbsp;Listboxes is 
            read only and therefore cannot be set programmatically, but can be read 
            programmatically.
            <br />
            <asp:Button ID="ButtonRead" runat="server" onclick="ButtonRead_Click" 
                Text="Read" />
            <br />
            <br />
            &nbsp;This controls do not force a postback automatically!</asp:Panel>
        <asp:Panel ID="Panel4" runat="server" Style="position: relative; top: -160px; left: 102px;
            height: 100px; width: 560px;" BorderStyle="Solid" BorderWidth="1px">
            <asp:Label ID="Label1" runat="server" Text="<%# CustomRegionField() %>"></asp:Label>
            &nbsp;
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Text="<%# CustomRegionField() %>"></asp:TextBox>
            <br />
            <asp:Button ID="ButtonForceDataBinding2" runat="server" 
                OnClick="ButtonForceDataBinding_Click" Text="Force DataBinding" Width="139px" />
            &nbsp; Neither, do these.</asp:Panel>
    </div>
    </form>
</body>
</html>
