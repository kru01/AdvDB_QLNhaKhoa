<a name="readme-top"></a>

# AdvDB - QLNhaKhoa and Logical & Physical Design

-   Group project from HCMUS's 2023 Advanced Database course.

## Content

-   `2223-CSDLNC-DA#3.pdf` contains all the tasks and requirements of the project (in Vietnamese).
-   `Report.pdf` includes our documentation for all the designs and required tasks (in Vietnamese).

### QLNhaKhoa and assets

Source code and resources pertaining to the C# WinForms app.

### SQL

All folders and files are pretty self-explanatory, but here are some notable things,

-   `setupDB.bat` constructs the database and populating all standard data (from `data` folder).
-   `setupDB_bigData.bat` constructs the database and populating all big data.
    -   Aside from certain fixed-size tables, i.e., `PHONGKHAM`, `DANHMUC`, `RANG`, `BEMATRANG`, all the others are generated to have as close to **99999** rows as possible. This refers to the files in `bigData` folder that will replace their counterparts in `data`.
    -   All data are inserted using stored procedures. However, with some tables' strict constraints, it is expected that many data won't pass the checks. The two tables suffering the most losses are, `LICHHEN` with only **99342** rows remaining, and `TOATHUOC` **93049** rows.

## Getting Started

### Prerequisites

-   Windows 10 or 11.
-   **_For WinForms development:_**
    -   Visual Studio 2022 and its `.NET desktop development` workload.
-   SQL Server 2022 Developer and SQL Server Management Studio (SSMS) 19.2.
-   _(Optional)_ Any decent code editor, preferably VSCode.
    -   It just makes editing the database's source code easier.

### Installation

-   Clone the repo.

<p align="right">(<a href="#readme-top">back to top</a>)</p>

## Usage

### To set up the database

1. Start the `SQL Server` and connect to it.
    - Make sure you have sufficient privileges.
1. Navigate into `SQL` folder.
1. Run `setupDB.bat` or `setupDB_bigData.bat`.
    - The partition files will be stored in the `C` drive, inside a folder named `N03_SQLPartitions`, which is created by the batch files.
        - If this storage should be moved, the filepath specified in each batch file, and all `FILENAME` fields in every script belonging to the `partitions` folder need to be updated accordingly.
        - If the `setupDB.bat`'s path is not changed, you need to manually create the new storage folder. Otherwise, **_SQL Server won't generate the folder if it doesn't exist_**.
    - For `setupDB_bigData`, the average time for the setup to complete falls in the range of **_4 to 5 hours_**. It's possible to manually run each script, even so, **_the execution order in the batch files should still be respected_**.

## Built With

[vsicon]: https://skillicons.dev/icons?i=visualstudio&theme=dark
[vsurl]: https://visualstudio.microsoft.com/vs/
[dotneticon]: https://skillicons.dev/icons?i=dotnet
[dotneturl]: https://dotnet.microsoft.com/en-us/download/dotnet/8.0
[sqlservericon]: https://upload.wikimedia.org/wikipedia/de/thumb/8/8c/Microsoft_SQL_Server_Logo.svg/90px-Microsoft_SQL_Server_Logo.svg.png
[sqlserverurl]: https://www.microsoft.com/en-us/sql-server/sql-server-downloads
[ssmsicon]: https://i.imgur.com/cIfvzqP.png
[ssmsurl]: https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16
[vscodeicon]: https://skillicons.dev/icons?i=vscode&theme=dark
[vscodeurl]: https://code.visualstudio.com/
[windowsicon]: https://cdn.jsdelivr.net/gh/devicons/devicon/icons/windows8/windows8-original.svg
[windowsurl]: https://www.microsoft.com/en-us/windows/

| [![VisualStudio2022][vsicon]][vsurl] | [![.NET8.0][dotneticon]][dotneturl] | [![SQLServer][sqlservericon]][sqlserverurl] | [![SSMS][ssmsicon]][ssmsurl] | [![VSCode][vscodeicon]][vscodeurl] | [![Windows][windowsicon]][windowsurl] |
| :----------------------------------: | :---------------------------------: | :-----------------------------------------: | :--------------------------: | :--------------------------------: | :-----------------------------------: |
|             2022 v17.8.3             |                 8.0                 |               Developer 2022                |          19.2.56.2           |               1.85.0               |     &nbsp;&nbsp; 11 &nbsp;&nbsp;      |

## Meet The Team

<div align="center">
  <a href="https://github.com/phongan1x5"><img alt="phongan1x5" src="https://github.com/phongan1x5.png" width="60px" height="auto"></a>&nbsp;&nbsp;&nbsp;
  <a href="https://github.com/kru01"><img alt="kru01" src="https://github.com/kru01.png" width="60px" height="auto"></a>&nbsp;&nbsp;&nbsp;
  <a href="https://github.com/faithdanghuy"><img alt="faithdanghuy" src="https://github.com/faithdanghuy.png" width="60px" height="auto"></a>&nbsp;&nbsp;&nbsp;
  <a href="https://github.com/sinful-johnny"><img alt="sinful-johnny" src="https://github.com/sinful-johnny.png" width="60px" height="auto"></a>&nbsp;&nbsp;&nbsp;
  <a href="https://github.com/KyleKennyNelson"><img alt="KyleKennyNelson" src="https://github.com/KyleKennyNelson.png" width="60px" height="auto"></a>&nbsp;&nbsp;&nbsp;
</div>

<p align="right">(<a href="#readme-top">back to top</a>)</p>
