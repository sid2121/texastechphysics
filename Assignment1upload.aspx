<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Assignment1upload.aspx.cs" Inherits="Assignment1upload" %>



<asp:Content runat="server" ContentPlaceHolderID="MainContent">


    

   <div class="container">
        
       <div class="col-sm-8 text-left"> 
      <h1>Upload assignment 1</h1>
           <br/>
      <h4>Deadline for assignment 1: <mark>02/12/2018</mark>
          </h4>
    <br/>
        <p><asp:FileUpload ID="FileUpload1" runat="server" />
            <br/>
                   <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Upload file" />
     </p>
             
        
         </div>
   </div>



</asp:Content>

