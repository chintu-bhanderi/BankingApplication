<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="RegistrationForm.signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>New Account Creation</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-iYQeCzEYFbKjA/T2uDLTpkwGzCiq6soy8tYaI1GyVh/UjpbCx/TYkiZhlZB6+fzT" crossorigin="anonymous">
</head>
<body>
    <div class="container">
        <form class="row g-3" runat="server">
            <div class="col-md-6">
                <label for="floatingName" class="form-label">Name</label>
                <input
                    type="text"
                    class="form-control"
                    id="floatingName"
                    placeholder="Enter Your Name"
                    runat="server"
                    required />
            </div>
            <div class="col-md-6">
                <label for="flotingaccountNumber" class="form-label">Account Number</label>
                <input
                    type="password"
                    class="form-control"
                    id="flotingaccountNumber"
                    placeholder="Enter your Account Number"
                    runat="server"
                    required />
            </div>
            <div class="col-md-6">
                <label for="inputEmail4" class="form-label">Email</label>
                <input
                    type="email"
                    class="form-control"
                    id="inputEmail4"
                    runat="server"
                    placeholder="Enter Your E-mail Id"
                    required />
            </div>
            <div class="col-md-6">
                <label for="bankId" class="form-label">Bank ID</label>
                <input
                    type="text"
                    runat="server"
                    class="form-control"
                    placeholder="Enter Your Unique Bank ID"
                    id="bankId" />
            </div>
            <div class="col-md-6">
                <label for="inputPassword4" class="form-label">Password</label>
                <input
                    type="password"
                    class="form-control"
                    id="inputPassword4"
                    placeholder="Create New Password"
                    runat="server"
                    required />
            </div>
            <div class="col-md-6">
                <label for="floatingconfirmPassword" class="form-label">Password</label>
                <input
                    type="password"
                    class="form-control"
                    id="floatingconfirmPassword"
                    runat="server"
                    placeholder="Confirm Your Password" />
            </div>
            <div class="col-12">
                <label for="inputAddress" class="form-label">Address</label>
                <input
                    type="text"
                    class="form-control"
                    id="inputAddress"
                    placeholder="Enter Your Address :- 182, Wallmart Street" />
            </div>
            <div class="col-12">
                <label for="inputAddress2" class="form-label">Address 2</label>
                <input
                    type="text"
                    class="form-control"
                    id="inputAddress2"
                    placeholder="Optional" />
            </div>
            <div class="col-md-6">
                <label for="inputCity" class="form-label">City</label>
                <input
                    type="text"
                    class="form-control"
                    id="inputCity"
                    placeholder="Enter Your City"
                    runat="server"
                    required />
            </div>
            <div class="col-md-4">
                <label for="inputState" class="form-label">State</label>
                <select id="inputState" class="form-select">
                    <option selected>Choose...</option>
                    <option value="Andhra Pradesh">Andhra Pradesh</option>
                    <option value="Andaman and Nicobar Islands">Andaman and Nicobar Islands
                    </option>
                    <option value="Arunachal Pradesh">Arunachal Pradesh</option>
                    <option value="Assam">Assam</option>
                    <option value="Bihar">Bihar</option>
                    <option value="Chandigarh">Chandigarh</option>
                    <option value="Chhattisgarh">Chhattisgarh</option>
                    <option value="Dadar and Nagar Haveli">Dadar and Nagar Haveli
                    </option>
                    <option value="Daman and Diu">Daman and Diu</option>
                    <option value="Delhi">Delhi</option>
                    <option value="Lakshadweep">Lakshadweep</option>
                    <option value="Puducherry">Puducherry</option>
                    <option value="Goa">Goa</option>
                    <option value="Gujarat">Gujarat</option>
                    <option value="Haryana">Haryana</option>
                    <option value="Himachal Pradesh">Himachal Pradesh</option>
                    <option value="Jammu and Kashmir">Jammu and Kashmir</option>
                    <option value="Jharkhand">Jharkhand</option>
                    <option value="Karnataka">Karnataka</option>
                    <option value="Kerala">Kerala</option>
                    <option value="Madhya Pradesh">Madhya Pradesh</option>
                    <option value="Maharashtra">Maharashtra</option>
                    <option value="Manipur">Manipur</option>
                    <option value="Meghalaya">Meghalaya</option>
                    <option value="Mizoram">Mizoram</option>
                    <option value="Nagaland">Nagaland</option>
                    <option value="Odisha">Odisha</option>
                    <option value="Punjab">Punjab</option>
                    <option value="Rajasthan">Rajasthan</option>
                    <option value="Sikkim">Sikkim</option>
                    <option value="Tamil Nadu">Tamil Nadu</option>
                    <option value="Telangana">Telangana</option>
                    <option value="Tripura">Tripura</option>
                    <option value="Uttar Pradesh">Uttar Pradesh</option>
                    <option value="Uttarakhand">Uttarakhand</option>
                    <option value="West Bengal">West Bengal</option>
                </select>
            </div>
            <div class="col-md-2">
                <label for="floatinginputZip" class="form-label">Zip</label>
                <input
                    runat="server"
                    type="text"
                    class="form-control"
                    id="floatinginputZip"
                    placeholder="Enter Pin Code"
                    required />
            </div>
            <div class="col-12">
                <div class="form-check">
                    <input class="form-check-input" type="checkbox" id="gridCheck" />
                    <label class="form-check-label" for="gridCheck">
                        <a href="#">I agree to accept
                <strong>ALL TERMS AND CONDITION SPECIFIED BY BANK</strong></a>
                    </label>
                </div>
            </div>
            <asp:Button ID="Button1" runat="server" Text="Sign Up" CssClass="btn-primary" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" CausesValidation="false" Text="Home" CssClass="btn-primary" OnClick="Button1_Click2" />
        </form>
    </div>
</body>
</html>
