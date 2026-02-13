<h1>Indian States API – ASP.NET Web Forms Demo</h1>

<p>
A professional ASP.NET Web Forms implementation demonstrating how to consume the
<strong>Indian States API</strong> and display all Indian states in a modern
<strong>black theme dropdown UI</strong>.
</p>

<hr />

<h2>🌐 Live API Endpoint</h2>

<p>
<a href="https://indianstatesapi-production.up.railway.app/api/states" target="_blank">
https://indianstatesapi-production.up.railway.app/api/states
</a>
</p>

<hr />

<h2>🎯 Project Overview</h2>

<table border="1" cellpadding="10" cellspacing="0">
  <tbody>
    <tr>
      <td><strong>Project Type</strong></td>
      <td>ASP.NET Web Forms Application</td>
    </tr>
    <tr>
      <td><strong>Theme</strong></td>
      <td>Modern Black / Dark UI</td>
    </tr>
    <tr>
      <td><strong>API Type</strong></td>
      <td>REST API (JSON)</td>
    </tr>
    <tr>
      <td><strong>HTTP Method</strong></td>
      <td>GET</td>
    </tr>
    <tr>
      <td><strong>Hosting</strong></td>
      <td>Railway (Dockerized ASP.NET Core API)</td>
    </tr>
    <tr>
      <td><strong>Frontend</strong></td>
      <td>ASP.NET Web Forms (.aspx)</td>
    </tr>
    <tr>
      <td><strong>Backend API</strong></td>
      <td>ASP.NET Core Web API</td>
    </tr>
  </tbody>
</table>

<hr />

<h2>🖼️ Application Screenshots</h2>

<p><strong>1️⃣ Dropdown Open – State List (Dark Theme)</strong></p>

<p>
<img src="./screenshots/state-dropdown-open.png"
     alt="Indian States Dropdown Open"
     width="700" />
</p>

<p><strong>2️⃣ Selected State – Clean UI View</strong></p>

<p>
<img src="./screenshots/state-selected.png"
     alt="Indian States Dropdown Selected"
     width="700" />
</p>

<hr />

<h2>⚙️ How It Works</h2>

<table border="1" cellpadding="10" cellspacing="0">
  <tbody>
    <tr>
      <td>1</td>
      <td>ASP.NET Web Forms page loads</td>
    </tr>
    <tr>
      <td>2</td>
      <td>API is called using HttpClient</td>
    </tr>
    <tr>
      <td>3</td>
      <td>JSON response is deserialized using Newtonsoft.Json</td>
    </tr>
    <tr>
      <td>4</td>
      <td>States are bound to ASP.NET DropDownList</td>
    </tr>
    <tr>
      <td>5</td>
      <td>User selects a state in a black themed UI</td>
    </tr>
  </tbody>
</table>

<hr />

<h2>📦 API Sample Response</h2>

<pre>
[
  {
    "id": 1,
    "name": "Andhra Pradesh"
  },
  {
    "id": 2,
    "name": "Arunachal Pradesh"
  }
]
</pre>

<hr />

<h2>✅ Use Cases</h2>

<ul>
  <li>Registration Forms</li>
  <li>Address Management</li>
  <li>Government Portals</li>
  <li>Mobile & Web Applications</li>
  <li>Educational Projects</li>
</ul>

<hr />

<h2>👨‍💻 Author</h2>

<p>
<strong>FATEHALI ABBASALI</strong><br />
ASP.NET Developer | API Builder
</p>

<hr />

<h2>📄 License</h2>

<p>
This project is open-source and free to use for learning and development purposes.
</p>

<p>
Powered by <strong>Indian States API</strong>
</p>
