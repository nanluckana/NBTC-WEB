<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Food.aspx.cs" Inherits="My3tier.Food" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblcandycode" runat="server" Text="รหัสขนมหวาน :"></asp:Label>
        <asp:TextBox ID="txtcandyodcode" runat="server" Text="รหัสอาหาร :"></asp:Label>
        <asp:TextBox ID="txtfoodcode" runat="server"></asp:TextBox><br/>
        <asp:Label ID="lblfoodname" runat="server" Text="ชื่ออาหาร :"></asp:Label>
        <asp:TextBox ID="txtfoodname" runat="server"></asp:TextBox><br/>
        <asp:Label ID="lblprice" runat="server" Text="ราคา :"></asp:Label>
        <asp:TextBox ID="txtprice" runat="server"></asp:TextBox><br/>
        <asp:Label ID="lblcategoryfood" runat="server" Text="ประเภทอาหาร :"></asp:Label>
        <asp:DropDownList ID="drpcategoryfood" runat="server" >
        </asp:DropDownList><br/>
        <br/>
        <asp:Button ID="btnsave" runat="server" Text="บันทึก" onclick="btnsave_Click" />
        <asp:Button ID="btnsearch" runat="server" Text="ค้นหาข้อมูล" 
            onclick="btnsearch_Click" />
        <asp:Button ID="btnserchbyname" runat="server" Text="ค้นหาด้วยชื่อ" 
            onclick="btnserchbyname_Click" />
        <asp:Button ID="btndelete" runat="server" Text="ลบข้อมูล" 
            onclick="btndelete_Click" />
        <asp:Button ID="btntest" runat="server" Text="ทดสอบ" onclick="btntest_Click" />
        
    </div>
    <p>
        <asp:Label ID="lblmassage" runat="server" Text="lblmassage"></asp:Label>
        <asp:GridView ID="grdfood" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:CheckBox ID="chkRow" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Food_code" HeaderText="รหัสอาหาร" />
                <asp:BoundField DataField="food_category_code" HeaderText="รหัสประเภทอาหาร" />
                <asp:BoundField DataField="Food_name" HeaderText="ชื่ออาหาร" />
                <asp:BoundField DataField="price" HeaderText="ราคา" />
            </Columns>
        </asp:GridView><br/>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </p>
    </form>
</body>
</html>
