<h1> SignalR Real-Time Notifications with ASP.NET Core Web API and Blazor </h1>

<h3> Overview </h3>
<p> This project demonstrates a real-time notification system using <strong>ASP.NET Core Web API</strong> and <strong> Blazor. </strong>. The server sends the current server time to connected clients every 
  5 seconds using <strong>SignalR</strong>.  Authentication is managed via token-based authentication, where users need to provide a valid username and password to receive notifications. </p>

<h3> Features </h3>
<ul>
  <li>Real-time updates with SignalR</li>
  <li>Background service to retrieve and send server time</li>
  <li>Token-based authentication for client requests</li>
  <li>Blazor client for receiving and displaying notifications</li>
</ul>

<h3> Prerequisites </h3>
<ul>
  <li>.NET SDK 8.0 or later</li>
  <li>Visual Studio 2022 or later</li>
  <li>Basic understanding of ASP.NET Core, SignalR, and Blazor</li>
</ul>

<h3> Setup </h3>
<h5> Clone the Repository </h5>
<p></p>
<div class="codehilite">
<pre><code> 
git clone https://github.com/ayethandar07/SignalR-Real-Time-Notifications.git
</code></pre>
</div>

<h5> Install Dependencies </h5><p></p>
<div class="codehilite">
<pre><code> 
dotnet restore
</code></pre>
</div>

<h5> Configure the Project </h5><p></p>
<div class="codehilite">
<pre><code> 
{
  "Jwt": {
    "Key": "your-secret-key",
    "Issuer": "your-issuer",
    "Audience": "your-audience"
  }
}
</code></pre>
</div>

<h3>Troubleshooting</h3>
<ul>
  <li>Authentication Issues: Ensure that your username and password are correct and match the credentials stored on the server.</li>
  <li>Connection Problems: Verify that the SignalR hub URL is correct and that the server is running.</li>
</ul>

<h5> Contact </h5>
<p> For questions or feedback, please contact athandar1998@gmail.com. </p>
