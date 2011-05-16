<%@ Page Language="C#" 
         Inherits="System.Web.Mvc.ViewPage<windsor_ioc_spike.Views.ViewModels.Home_ViewModel>" %>
<%@ Import Namespace="windsor_ioc_spike.Models" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home/Index</title>
</head>
<body>
   <h3>Home/Index</h3> 

   <b>eddie woud go</b>

   <p>
   <% foreach (Team team in ViewData.Model.Teams) { %>
     <div>
       <b><%= team.City %></b> 
       <span class="nickname"><%= team.Nickname %></span>
     </div>
    <%} %>
   </p>
</body>
</html>
