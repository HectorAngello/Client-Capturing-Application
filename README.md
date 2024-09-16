# Client-Capturing-Application

## The Client Capturing Application

This project includes two applications:
1. **Client Capture Application**
2. **Client Analytics Application**

### SQL Server Table Creation

To get started with the Client Capture Application, ensure you have the SQL Server database set up correctly. Below is the SQL statement to create the `Clients` table:

```sql
CREATE TABLE Clients
(
   Id INT PRIMARY KEY IDENTITY(1,1),
   ClientName NVARCHAR(100) NOT NULL,
   DateRegistered DATE NOT NULL,
   Location NVARCHAR(100) NOT NULL,
   NumberOfUsers INT NOT NULL
);
```

## Using the Applications:
1. **ClientCaptureApp:** *Use this application to capture client data and store it in the SQL Server database.*
  
2. **ClientAnalyticsApp:** *Use this application to display analytics of the captured client data by reading from the same database.*

## Additional Notes
Ensure that the *connection string* in the *appsettings.json* file of each project is correctly set to point to your local SQL Server instance.

The applications should be running on different ports. Verify the ports in the launchSettings.json files of each project.
