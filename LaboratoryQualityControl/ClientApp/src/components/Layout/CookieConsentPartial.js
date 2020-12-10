@using Microsoft.AspNetCore.Http.Features

@{
    var consentFeature = Context.Features.Get<ITrackingConsentFeature>();
    var showBanner = !consentFeature?.CanTrack ?? false;
    var cookieString = consentFeature?.CreateConsentCookie();
}

@if (showBanner)
{
    <nav id="cookieConsent" className="navbar navbar-default navbar-fixed-top" role="alert">
        <div className="container">
            <div className="navbar-header">
                <button type="button" className="navbar-toggle" data-toggle="collapse" data-target="#cookieConsent .navbar-collapse">
                    <span className="sr-only">Toggle cookie consent banner</span>
                    <span className="icon-bar"></span>
                    <span className="icon-bar"></span>
                    <span className="icon-bar"></span>
                </button>
                <span className="navbar-brand"><span className="glyphicon glyphicon-info-sign" aria-hidden="true"></span></span>
            </div>
            <div className="collapse navbar-collapse">
                <p className="navbar-text">
                    Use this space to summarize your privacy and cookie use policy.
                </p>
                <div className="navbar-right">
                    <a asp-controller="Home" asp-action="Privacy" className="btn btn-info navbar-btn">Learn More</a>
                    <button type="button" className="btn btn-default navbar-btn" data-cookie-string="@cookieString">Accept</button>
                </div>
            </div>
        </div>
    </nav>
    <script>
        (function () {
            document.querySelector("#cookieConsent button[data-cookie-string]").addEventListener("click", function (el) {
                document.cookie = el.target.dataset.cookieString;
                document.querySelector("#cookieConsent").classList.add("hidden");
            }, false);
        })();
    </script>
}