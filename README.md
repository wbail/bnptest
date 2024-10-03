# BNP Interview Test

## Table of Contents
- [API :ticket:](#api-ticket)
  - [Table of Contents](#table-of-contents)
  - [Description](#description)
  - [Features :rocket:](#features-rocket)
  - [API - Endpoints :satellite:](#api---endpoints-satellite)
    - [GET /api/securities]
  - [Requirements :wrench:](#requirements-wrench)
  - [Installation :gear:](#installation-gear)
  - [Usage :building_construction:](#usage-building_construction)
  - [Support :construction_worker:](#support-construction_worker)
    - [Developers](#developers)

## Description

As a software developer you should create a service class/layer that allows you to retrieve and store the prices of a list of securities. Please note that:

- A security is a financial instrument identified by an ISIN, an alphanumeric code of 12 characters.

- The service should be written according to SOLID principles with the usage of Dependency Injection.

- The service should have a method which receives as input a list of ISIN.

- The service has to retrieve and store the price for each ISIN in a SQL server database.

- The price of an ISIN must be retrieved through an external web API: ```https://securities.dataprovider.com/securityprice/{isin}```

- The service should be unit tested

## Features :rocket:
- __Get the Price:__ Retrieves the prices from a list of isins
- __Validation:__ Validate if an ```ISIN``` has 12 chars length
- __Logs:__ The application is prepared to save logs in case of failure.
- __Open API:__ Using Swagger for API versioning and specification

## API - Endpoints :satellite:
### GET api/Securities?isin=string&isin=string
- Response
```
[
  "string",
  "string"
]
```

## Requirements :wrench:

- Git ([download](https://git-scm.com/downloads))
- .NET ([download](https://dotnet.microsoft.com/download/))
- Visual Studio 2022

## Installation :gear:

Open the cmd and execute: ```git clone https://github.com/wbail/bnptest```

## Usage :building_construction:

1. Open the Visual Studio 2022
2. Open the solution
3. Execute the application (opens automatically the Swagger)
5. Call the GET method

## Support :construction_worker:

In case of features or bugs, please contact me or open a PR

### Developer(s)
- Guilherme Bail ([email](mailto:guilhermedanbail@gmail.com), [github](https://github.com/wbail))