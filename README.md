# .NET 8 API with SQL Server and In-Memory SQLite

This repository contains a C# .NET 8 API project that uses SQL Server for production execution and SQLite in-memory for unit testing.

## Setup

### Database Creation

Before running the application, create the necessary database and table in SQL Server using the following SQL script:

```sql
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Car](
    [Id] [int] IDENTITY(1,1) NOT NULL,
      NOT NULL,
    [CreatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Car] PRIMARY KEY CLUSTERED 
(
    [Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT INTO Car (Name, CreatedDate)
VALUES
    ('Chevrolet Silverado', '2024-09-07 00:01:53.350'),
    ('Toyota RAV4', '2024-09-07 00:01:53.353'),
    ('Tesla Model Y', '2024-09-07 00:01:53.357'),
    ('Honda CR-V', '2024-09-07 00:01:53.360'),
    ('Nissan Rogue', '2024-09-07 00:01:53.363'),
    ('Ram Pickup', '2024-09-07 00:01:53.367'),
    ('Toyota Camry', '2024-09-07 00:01:53.370'),
    ('Jeep Grand Cherokee', '2024-09-07 00:01:53.373'),
    ('Toyota Highlander', '2024-09-07 00:01:53.377');
```

### Configuration
By default, the connection string points to a Server **localhost\SQLEXPRESS** named, database **EliasdcDev** with username **test** and password **test**. You can modify this in the **appsettings.json** file located in the **2-Api** folder within the **Cars** API project.

### Running the API
To run the API, build and start the project. The Swagger UI will be available for you to interact with the API and test the GetCarByName endpoint.

## More Details
### For additional information and insights, please refer to the full post available at: https://eliasdc.dev/index.php/2024/09/07/241/ 
