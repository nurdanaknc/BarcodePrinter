<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<link rel="preconnect" href="https://fonts.googleapis.com">
<link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
<link href="https://fonts.googleapis.com/css2?family=Roboto&display=swap" rel="stylesheet">

<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
        <div>
           
            <p><asp:Label ID="Label1" runat="server" Text="HAMMADDE BARKODU" Font-Bold="true"  Width="305" style="text-align:center; font-family: 'Roboto', sans-serif;"></asp:Label></p>
            
            

            <table cellpadding="4" cellspacing="4" width="35%" > 
                   
                   <tr>
                       <td>  <asp:Label runat="server" for="stokkodu"  style="font-family: 'Roboto', sans-serif;" >stok kodu: </asp:Label> </td>
                       <td> <asp:TextBox ID="stokkodu" runat="server"  Width="200" ></asp:TextBox>   </td>
                   </tr>
                   <tr>   
                       <td> <asp:Label runat="server" for="stokadı"  style="font-family: 'Roboto', sans-serif;" >stok adı: </asp:Label> </td>
                       <td> <asp:TextBox ID="stokadı" runat="server" Width="200" ></asp:TextBox> </td>
                   </tr>
                   <tr>
                       <td> <asp:Label runat="server" for="miktar"  style="font-family: 'Roboto', sans-serif;" >miktar: </asp:Label> </td>
                       <td> <asp:TextBox ID="miktar" runat="server" Width="200" ></asp:TextBox>  </td>
                       <td> <asp:DropDownList ID="birim" AutoPostBack="True" runat="server">
                                  <asp:ListItem Selected="True" Value="cm"></asp:ListItem>
                                  <asp:ListItem Value="m"></asp:ListItem>
                                  <asp:ListItem Value="mm"></asp:ListItem>
                            </asp:DropDownList> </td>
                   </tr>
                   <tr>
                       <td> <asp:Label runat="server" for="lotno"  style="font-family: 'Roboto', sans-serif;" >lot no: </asp:Label> </td>
                       <td> <asp:TextBox ID="lotno" runat="server" Width="200" ></asp:TextBox> </td>
                   </tr>
                   <tr>
                       <td> <asp:Label runat="server" for="kod"  style="font-family: 'Roboto', sans-serif;" >kod: </asp:Label> </td>
                       <td> <asp:TextBox ID="kod" runat="server" Width="200" ></asp:TextBox> </td>
                   </tr>
                    <tr>
                        <td></td>
                        <td><asp:Button ID="Button1" runat="server" Text="Barkod Olustur" OnClick="Button1_Click"  Width="208"  style="font-family: 'Roboto', sans-serif;" /> </td>
                    </tr>


              </table>
                    
            
            
        </div>
     

    </form>
</body>

</html>
