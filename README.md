
<h1 align="center">
  Client Register
</h1>
<div align="center">

  <h3>Built With</h3>

  <img src="https://img.shields.io/badge/PostgreSQL-316192?style=for-the-badge&logo=postgresql&logoColor=white" height="30px"/>
  <img src="https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=dot-net&logoColor=white" height="30px"/>
  <img src="https://img.shields.io/badge/ASP.NET_Core-5C2D91?style=for-the-badge&logo=dot-net&logoColor=white" height="30px"/>
  <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" height="30px"/>

</div>

<br/>

# Description

An api for register name clients. You can post a name, get the names posted before, get a client by id, update and delete registers.
</br>

## Features

-   Register client
-   Get all clients registered
-   Get a client by register id
-   Update register
-   Delete register

</br>

## API Reference

#### Register

```http
POST /api/client
```

#### Request:

| Body              | Type     | Description                    |
| :---------------- | :------- | :----------------------------- |
| `Name`            | `string` | **Required**. name             |


#### Get clients

```http
GET /api/client
```

#### Response:

```json
[
  {
    "id": 1,
    "name": "Rodrigo"
  },
  {
    "id": 2,
    "name": "Leonardo"
  }
]
```
</br>

#### Get a client by identifier

```http
GET /api/client/:id
```

#### Request:

| Params | Type      | Description            |
| :----- | :-------- | :--------------------- |
| `id`   | `integer` | **Required**. valid id |

<br/>

#

#### Update a register by identifier

```http
PUT /api/client/:id
```

#### Request:

| Params | Type      | Description            |
| :----- | :-------- | :--------------------- |
| `id`   | `integer` | **Required**. valid id |

| Body              | Type     | Description                    |
| :---------------- | :------- | :----------------------------- |
| `Name`            | `string` | **Required**. name             |

<br/>

#

#### Delete a register by identifier

```http
DELETE /api/client/:id
```

#### Request:

| Params | Type      | Description            |
| :----- | :-------- | :--------------------- |
| `id`   | `integer` | **Required**. valid id |

<br/>

#

## Server Ports

If you use localhost the server will up: http://localhost:5148/ and https://localhost:7120/

## Environment Variables

To run this project, you will need to add the following environment variables to your .env file

`DB_HOST = localhost` (example)

`DB_PORT = number #recommended:5432`

`DB_NAME = any string`

`DB_USER = database user`

`DB_PASSWORD = database password`

</br>

## Run Locally

Clone the project

```bash
  git clone https://github.com/leolucasguedes/Teste-Cliente-.Net
```

Go to the project directory

```bash
  cd Teste-Cliente-.Net
```

Install dependencies

```bash
  dotnet restore
```

Create database and migration

```bash
  dotnet ef migrations add NomeDaMigracao
  dotnet ef database update
```

Start the server

```bash
  dotnet run
```

</br>

## Lessons Learned

In this project I learned a lot about how to create a full API server using .NET, ASP.NET Core and c# 

</br>

## Authors

-   [@leolucasguedes](https://www.github.com/leolucasguedes)

<br/>

#

<a  href="mailto:contato.leonardo.lucas0611@gmail.com" target="_blank"><img src="https://img.shields.io/badge/Ask%20me-anything-1abc9c.svg"></a>