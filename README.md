# Membership Management System (VB.NET)

A Windows Forms desktop application for managing organizational membership, renewals, and reports. Built in VB.NET targeting .NET 8 (Windows) with SQL Server as the backing store.

This is a VB.NET port of the original C# Membership Management System and preserves the same architecture: a single `MainForm` that hosts swappable `UserControl`s, a centralized `DBHelper` data-access layer, and parameterized stored procedures for every database operation.

---

## Features

- **Authentication** – role-based login (`Administrator` / `User`) backed by the `Users` table.
- **Members** – full CRUD with filter by State / Member Type and free-text search across name, member number, application number, mobile, and Aadhar.
- **Renewals** – add and view renewal receipts linked to members, with receipt type, number, date, and amount.
- **Reports** – generate Member List and Renewal List reports over a selectable date range, display in a grid, and export to CSV.

---

## Prerequisites

| Component | Version |
|---|---|
| Visual Studio | 2022 (17.8+) with the **.NET desktop development** workload |
| .NET SDK | .NET 8 SDK |
| SQL Server | 2005 or later (Express / Developer / Standard) — script is 2005-compatible |
| OS | Windows 10 / 11 |

---

## Setup

### 1. Create the database

Open SQL Server Management Studio (SSMS) and connect to your instance, then run:

```
MembershipApp\Database\MembershipDB_Setup.sql
```

The script creates a database named `MembershipDB`, all tables (`Users`, `States`, `MemberTypes`, `Members`, `Renewals`), all stored procedures, and seed data (states, member types, sample members, sample renewals, and two login accounts).

### 2. Configure the connection string

Open `MembershipApp\App.config`. The default connection string points to a local default instance using Windows Authentication:

```xml
<connectionStrings>
  <add name="MembershipDB"
       connectionString="Data Source=(local);Initial Catalog=MembershipDB;Integrated Security=True;TrustServerCertificate=True"
       providerName="System.Data.SqlClient" />
</connectionStrings>
```

Adjust `Data Source` to your instance name (for example `.\SQLEXPRESS`) or switch to SQL authentication by replacing `Integrated Security=True` with `User ID=...;Password=...`.

### 3. Open and run

1. Open `MembershipApp.sln` in Visual Studio 2022.
2. Restore NuGet packages (happens automatically on first build — `System.Data.SqlClient` and `System.Configuration.ConfigurationManager` are referenced by the project).
3. Press **F5** to build and run.

### Default login credentials

| Username | Password | Role |
|---|---|---|
| `admin` | `admin123` | Administrator |
| `user`  | `user123`  | User |

---

## Project structure

```
MembershipApp/
├── MembershipApp.sln
├── README.md
└── MembershipApp/
    ├── MembershipApp.vbproj        SDK-style project, net8.0-windows
    ├── App.config                  Connection string
    ├── Program.vb                  Entry point
    ├── MainForm.vb / .Designer.vb  Host form — swaps Login/Dashboard
    │
    ├── Data/
    │   ├── DBHelper.vb             ADO.NET helper: ExecuteDataTable / NonQuery / Scalar
    │   └── SessionManager.vb       Static session holder (UserId, Role, etc.)
    │
    ├── UserControls/
    │   ├── LoginControl.vb         Username/password form
    │   ├── DashboardControl.vb     Header + TabControl (Members / Renewal / Reports)
    │   ├── MembersControl.vb       Member list + add/edit panel (panel-flip)
    │   ├── RenewalControl.vb       Renewal list + add/edit panel (panel-flip)
    │   └── ReportsControl.vb       Date-range reports + CSV export
    │
    └── Database/
        └── MembershipDB_Setup.sql  Full DB setup: tables + SPs + seed data
```

---

## Architecture overview

**Single host form + UserControls.** `MainForm` is maximized and fills its client area with one `MainPanel`. `ShowLogin()` and `ShowDashboard()` dispose the current control and instantiate the next one. This keeps navigation simple and avoids MDI overhead.

**Panel-flip add/edit.** The Members and Renewal controls each contain two `DockStyle.Fill` panels — a list panel (grid + filters + "Add" button) and an edit panel (form). Toggling `.Visible` switches views without any modal dialogs, matching the UX of the original C# build.

**Centralized data access.** `DBHelper` exposes three methods — `ExecuteDataTable`, `ExecuteNonQuery`, `ExecuteScalar` — all of which take a stored procedure name and a `SqlParameter()` array. Every database call in the app goes through these, and every call uses `CommandType.StoredProcedure` with `SqlParameter` binding, so user input is never concatenated into SQL.

**Upsert stored procedures.** `sp_SaveMember` and `sp_SaveRenewal` accept the primary key as a parameter. If it equals `0`, they `INSERT`; otherwise they `UPDATE`. This keeps the UI code symmetric between add and edit flows.

**Session state.** `SessionManager` is a `Shared`-only class that holds the current user's id, name, and role after login. Controls read from it directly rather than passing the session around.

---

## Notes

- The app targets `net8.0-windows`. Visual Studio 2005 cannot open SDK-style projects, so a current Visual Studio is required even though the SQL script remains SQL Server 2005-compatible.
- The reports module formats currency with the ₹ symbol and exports with proper CSV quoting (values containing commas, quotes, or newlines are escaped correctly).
- Passwords in the seed data are stored in plain text for demo simplicity. For production, replace `sp_AuthenticateUser` and the Users table with a hashed-password scheme (for example PBKDF2 / bcrypt).
