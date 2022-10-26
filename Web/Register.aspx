<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Web.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<title>Register</title>
</asp:Content>  
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="row no-gutters">
							<div class="col-md-7">
								<div class="contact-wrap w-100 p-md-5 p-4">
									<h3 class="mb-4">Register</h3>
									<div method="POST" id="contactForm" name="contactForm" class="contactForm">
										<div class="row">
											<div class="col-md-6">
												<div class="form-group">
													<label class="label" for="name">Full Name</label>
													<input type="text" class="form-control" name="name" id="namez" placeholder="Name" runat="server">
												</div>
											</div>
											<div class="col-md-6"> 
												<div class="form-group">
													<label class="label" for="email">Email Address</label>
													<input type="email" class="form-control" name="email" id="emailz" placeholder="Email" runat="server">
												</div>
											</div>
											<div class="col-md-6">
												<div class="form-group">
													<label class="label" for="Surname">Surname</label>
													<input type="text" class="form-control" name="surname" id="srname" placeholder="Surname" runat="server">
												</div>
											</div>
											
											<div class="col-md-12">
												<div class="form-group">
													<asp:Button ID="BtbVolunteer" class="btn btn-primary" runat="server" Text="Register" OnClick="BtbVolunteer_Click" />
													<asp:Label ID="regMessage" runat="server" Text=""></asp:Label>
													<div class="submitting"></div>
												</div>
											</div>
										</div>
									</div>
								</div>
							</div>
							<div class="col-md-5 d-flex align-items-stretch">
								<div class="info-wrap w-100 p-5 img" style="background-image: url(images/Tumelo.jpg);">
								</div>
							</div>
		  </div>
</asp:Content>


