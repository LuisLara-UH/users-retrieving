## User Dashboard Project

This project consists of two applications: a backend API built with ASP.NET Core and a frontend web application developed using HTML, CSS, and JavaScript. The backend API provides endpoints to retrieve user data, while the frontend web application fetches this data and displays it in a table format on a user dashboard page.

### Backend API (ASP.NET Core)

The backend API is responsible for handling requests related to user data. It provides two main endpoints:

1. **GET /api/users**: Returns a list of users.
2. **GET /api/users/{id}**: Returns a specific user by ID.

#### Technologies Used:
- ASP.NET Core
- C#
- RESTful API principles

### Frontend Web Application

The frontend web application fetches user data from the backend API and dynamically renders it on a user dashboard page. It utilizes HTML, CSS, and JavaScript to create a simple and intuitive user interface.

#### Features:
- Fetches user data from the backend API using `fetch()` method.
- Dynamically generates HTML table rows to display user data.
- Styles the user dashboard page for better readability and aesthetics.

#### Technologies Used:
- HTML
- CSS
- JavaScript

### Getting Started

To run this project locally, follow these steps:

1. Clone the repository to your local machine.
2. Navigate to the `backend` directory and open the solution file in Visual Studio or your preferred IDE.
3. Build and run the backend ASP.NET Core application.
4. Open a terminal and navigate to the `frontend` directory.
5. Open the `index.html` file in a web browser to view the user dashboard.

### Project Structure

```
User-Dashboard-Project/
│
├── backend/
│   ├── Controllers/
│   │   └── UserController.cs
│   │── User.cs
│   ├── Program.cs
│   └── ...
│
├── frontend/
│   ├── index.html
│   ├── script.js
│   ├── styles.css
│
└── README.md
```


### Contributors

- [Luis Lara](mailto:luis.lara.uh42@gmail.com)

### License

This project is licensed under the [MIT License](LICENSE).
