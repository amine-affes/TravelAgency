<div>
<h1 align="center">Optimize Income</h1>

<h3 align="center">This README file provides instructions for setting up the project using Git and Docker  </h3>


<p align="center">
  <a href="https://skillicons.dev">
    <img src="https://skillicons.dev/icons?i=git,docker" />
  </a>
</p>

<h3 align="center">This project built with:</h3>

<p align="center">
  <a href="https://skillicons.dev">
    <img src="https://skillicons.dev/icons?i=dotnet" />
  </a>
</p>
</div>

## Tech Stack 🛠️

**SCM:**  `Git version 2.25.1` 

**Containerization:**  `Docker version 24.0.7` 

**Server:**  `Dotnet version 8.0` 

**React:**  `React version 18` 

## Prerequisites 📌

Before proceeding with the setup instructions, ensure that you have the following prerequisites installed on your system:

-  Git : Version control system for managing code repositories.

-  Docker : Containerization platform for packaging and running applications.

## Setup Instructions ⚓

Follow these steps to set up the project:

1. Clone the project repository:

```sh
$ git clone <repository_url>
```
2. Navigate to the project directory:

```sh
$ cd <repository_directory>
```

3. Update your local repository with the latest changes from the remote `main` branch:


```sh
$ git pull origin main
```

## Deployment Instructions in Development Environment ⚙️

To deploy this application in a dev environment, follow these steps:



Run the Docker container:

```sh
$ docker-compose up --build -d
```
