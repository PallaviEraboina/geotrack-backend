# 🌍 GeoTrack Backend - Location API

GeoTrack Backend is a RESTful API built using **.NET 8 Web API** that provides location data for the GeoTrack frontend application.

It serves structured location data consumed by the React + Leaflet frontend to render interactive map visualizations.

---

## 🚀 Base URL

👉 [https://geotrack-backend-aqg6.onrender.com](https://geotrack-backend-aqg6.onrender.com)

---

## 🛠 Tech Stack

* .NET 8 Web API
* C#
* Entity Framework Core (InMemory Database)
* RESTful APIs
* JSON

---

## 📡 API Endpoints

### 📍 Get all projects

```http
GET /api/projects
```

### 📍 Get project by ID

```http
GET /api/projects/{id}
```

### Example Response

```json
[
  {
    "id": 1,
    "name": "West Gate Tunnel",
    "location": "Melbourne",
    "latitude": -37.8136,
    "longitude": 144.9631,
    "status": "In Progress"
  }
]
```

---

## 📘 Swagger API Docs

Swagger UI is available for testing endpoints:

👉 [https://geotrack-backend-aqg6.onrender.com/swagger](https://geotrack-backend-aqg6.onrender.com/swagger)

---

## 🔌 Features

* RESTful API for project/location data
* In-memory database for demo purposes
* JSON response format
* CORS enabled for frontend integration
* Swagger integration for API testing

---

## 🌐 CORS Configuration

Allows requests from:

* [https://geotrack-khaki.vercel.app](https://geotrack-khaki.vercel.app)

---

## 🚀 How to Run Locally

### 1. Clone repository

```bash
git clone https://github.com/PallaviEraboina/geotrack-backend.git
cd geotrack-backend
```

### 2. Restore dependencies

```bash
dotnet restore
```

### 3. Run project

```bash
dotnet run
```

---

## 📁 Project Structure

* Controllers → API endpoints
* Models → Data models
* Data → DbContext (InMemory DB)
* Program.cs → App configuration

---

## 👨‍💻 Author

Pallavi Eraboina
GitHub: [https://github.com/PallaviEraboina](https://github.com/PallaviEraboina)
