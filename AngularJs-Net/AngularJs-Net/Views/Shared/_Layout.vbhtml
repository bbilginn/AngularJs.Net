<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width" />
    <title>@ViewData("Title")</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
</head>
<body>

    <header>
        <div class="content-wrapper">
            <div class="float-left">
                <p class="site-title">
                    <a href="~/">Asp.Net ve AngularJs</a>
                </p>
            </div>
            <div class="float-right">
                <nav>
                    <ul id="menu">
                        <li><a href="https://github.com/bbilginn/AngularJs.Net"><img src="~/Images/github.png" alt="AngularJs.Net Vb.Net Sample" /></a></li>
                        <li><a href="https://github.com/bbilginn/AngularJs.Net/archive/master.zip"><img src="~/Images/github-down.png" alt="AngularJs.Net Vb.Net Sample Download" /></a></li>
                        @*<li>@Html.ActionLink("API", "Index", "Help", New With {.area = ""}, Nothing)</li>*@
                    </ul>
                </nav>
            </div>
        </div>
    </header>

    <div id="body">
        <section class="featured">
            <div class="content-wrapper">
                <hgroup class="title">
                    <h1>VB.Net ile AngularJs Uygulaması</h1>
                </hgroup>

            </div>
        </section>
        <section class="content-wrapper main-content clear-fix">
            @RenderBody()
        </section>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @RenderSection("scripts", required:=False)
</body>
</html>
