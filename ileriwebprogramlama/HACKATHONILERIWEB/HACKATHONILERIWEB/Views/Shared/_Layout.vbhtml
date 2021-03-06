<!DOCTYPE html>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - ASP.NET Uygulamam</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
</head>
<body style="background-image: url(../../Photo/bgg.jpg)">
  
    <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <asp:Image>
                    <a href="">
                        <img src="~/Photo/logoisim.png " width="150" style="padding-right:15px; padding-top:8px;" />
                    </a>
                </asp:Image>
                 

</div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav"">
                    <li>@Html.ActionLink("Hakkımızda", "Hizmetler", "Home")</li>
                    <li>@Html.ActionLink("Hizmetlerimiz", "Index", "Home")</li>
                    <li>@Html.ActionLink("Bize Ulaşın", "Contact", "Home")</li>
                    <li>@Html.ActionLink("Para Yükle", "Index", "Home")</li>
                    <li>@Html.ActionLink("Giriş Yap", "Contact", "Home")</li>
                </ul>
            </div>
        </div>
    </div>
    <div class="container body-content">
        @RenderBody()
      
        <hr />

    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>
