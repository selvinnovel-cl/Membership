# Membership Management System

A Windows Forms desktop application built with **VB.NET (.NET 8)** and **SQL Server** for managing membership records, renewals, and reports.

---

## Features

### Login
- Username & password authentication against SQL Server (`sp_AuthenticateUser`)
- Role-based session (`Administrator` / `User`)
- Press **Enter** in the password field to log in

### Members Tab
| Feature | Detail |
|---|---|
| Member grid | State Name, Member Type, Member No, Application No, Member Name, Address (3 lines), Pincode, Mobile, Aadhar, DOB/Age, Gender, Profession, Registered Through, Registered On |
| Filtering | State dropdown, Member Type dropdown, free-text Search |
| Add Member | Click **+ Add Member** to open the add/edit form |
| Edit Member | Double-click any grid row to open the edit form pre-populated |
| Save / Cancel | Calls `sp_SaveMember` (INSERT for new, UPDATE for existing) |

### Renewal Tab
| Feature | Detail |
|---|---|
| Renewal grid | State Name, Member Type, Member No, Member Name, Receipt Type, Receipt No, Receipt Date, Amount |
| Filtering | State dropdown, Member Type dropdown, free-text Search |
| Add Renewal | Click **+ Add Renewal** to open the add/edit form |
| Edit Renewal | Double-click any grid row to open the edit form |
| Save / Cancel | Calls `sp_SaveRenewal` |

### Reports Tab
| Feature | Detail |
|---|---|
| Report types | Member List, Renewal List |
| Date range | From Date / To Date filter |
| Generate | Loads data into grid with title and record count |
| Export | Save grid to a CSV file |

---

## Tech Stack

| Component | Technology |
|---|---|
| Language | VB.NET |
| Framework | .NET 8.0 Windows |
| UI | Windows Forms |
| Database | SQL Server 2019 / 2022 |
| Data Access | ADO.NET — parameterized stored procedures via `DBHelper.vb` |
| IDE | Visual Studio 2022 |

---

## Project Structure

```
MembershipApp.sln
└── MembershipApp/
    ├── Program.vb                              ← Entry point (STAThread Main)
    ├── MainForm.vb / .Designer.vb             ← Host form with full-size panel
    ├── App.config                             ← Connection string
    ├── Data/
    │   ├── DBHelper.vb                        ← Centralised ADO.NET helper
    │   └── SessionManager.vb                 ← Runtime user context
    ├── UserControls/
    │   ├── LoginControl.vb / .Designer.vb
    │   ├── DashboardControl.vb / .Designer.vb ← TabControl host + header bar
    │   ├── MembersControl.vb / .Designer.vb   ← mainPanel + addMemberPanel
    │   ├── RenewalControl.vb / .Designer.vb   ← mainPanel + addRenewalPanel
    │   └── ReportsControl.vb / .Designer.vb   ← Report grid + CSV export
    └── Database/
        └── MembershipDB_Setup.sql             ← Full DB setup (tables + SPs + seed data)
```

---

## Quick Start

### 1. Database Setup

Open **SSMS** and run against `master`:

```
MembershipApp/Database/MembershipDB_Setup.sql
```

This creates the database `MembershipDB` with all tables, stored procedures and seed data.

**Default login credentials:**

| Username | Password | Role |
|---|---|---|
| `admin` | `admin123` | Administrator |
| `user` | `user123` | User |

### 2. Update Connection String

Edit `MembershipApp/App.config`:

```xml
<add name="MembershipDB"
     connectionString="Server=YOUR_SERVER;Uid=YOUR_USER;Pwd=YOUR_PASSWORD;database=MembershipDB;"
     providerName="System.Data.SqlClient"/>
```

Common server values: `.\SQLEXPRESS`, `.\SQL2022`, `(local)`, or use `Integrated Security=True` to skip username/password.

### 3. Build & Run

Open `MembershipApp.sln` in **Visual Studio 2022** and press **F5**, or from the command line:

```bash
cd MembershipApp
dotnet restore
dotnet run
```

---

## Stored Procedures

| Procedure | Purpose |
|---|---|
| `sp_AuthenticateUser` | Login validation |
| `sp_GetStates` | Populate State dropdowns |
| `sp_GetMemberTypes` | Populate Member Type dropdowns |
| `sp_GetMembers` | List members with optional State/Type/Search filters |
| `sp_SaveMember` | INSERT (MemberId=0) or UPDATE member |
| `sp_GetRenewals` | List renewals with optional filters |
| `sp_SaveRenewal` | INSERT (RenewalId=0) or UPDATE renewal |
| `sp_Report_MemberList` | Member list report by registered date range |
| `sp_Report_RenewalList` | Renewal list report by receipt date range |

---

## Architecture Notes

- **DBHelper** — static helper; all DB calls use parameterized stored procedures (SQL injection safe)
- **SessionManager** — shared properties hold the logged-in user's ID, name and role
- **MainForm.MainPanel** — hosts `LoginControl` on startup; swaps to `DashboardControl` after login
- **DashboardControl** — header bar (app title, username, Logout button) + `TabControl` (Members, Renewal, Reports)
- **Panel flip pattern** — each content UserControl contains `mainPanel` (grid view) and `addPanel` (form view); toggled with `BringToFront()` and `Visible`
