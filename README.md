# _Pierre's Treats_

#### By _Liam Campbell_



#### _Description_

## Table of Contents

[Technologies Used](#technologies-used)  
[Description](#description)  
[Setup/Installation Requirements](#setup-and-installation-requirements)  
[Known Bugs](#known-bugs)  
[License](#License)

## Technologies Used

* _C#_
* _.NET_
* _HTML_
* _CSS_
* _SQL Workbench_
* _Entity Framework_
* _MVC_

---
## Description



---
## Setup and Installation Requirements

<details>
<summary><strong>Initial Setup</strong></summary>
<ol>
<li>Copy the git repository url: https://github.com/lcmpbll/PierresTreats
<li>Open a shell program and navigate to your desktop.
<li>Clone the repository for this project using the "git clone" command and including the copied URL.
<li>While still in the shell program, navigate to the root directory of the newly created file named "PierresTreats.Solution".
<li>From the root directory, navigate to the "PierresTreats" directory.
<li>Move onto "SQL Workbench" instructions below to re-create database necessary to run this project.
<br>
</details>

<details>
<summary><strong>SQL Workbench Configuration</strong></summary>
<ol>
<li>Create an appsetting.json file in the "PierresTreats" directory of the project*  
   <pre>PierresTreats.Solution
   └── PierresTreats
    └── appsetting.json</pre>
<li> Insert the following code** : <br>

<pre>{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=best_restaurants;uid=root;pwd=[YOUR-PASSWORD-HERE];"
  }
}</pre>
<small>*note: you must include your password in the code block section labeled "YOUR-PASSWORD-HERE".</small>
<small>**note: if you plan to push this cloned project to a public-facing repository, remember to add the appsettings.json file to your .gitignore before doing so.</small>

<li>Once "appsettings.json" file has been created, navigate back to SQL Workbench.


</details>

<details>
<summary><strong>To Run</strong></summary>
Navigate to:  
   <pre>PierresTreats.Solution
   └── <strong>PierresTreats</strong></pre>

Run `$ dotnet restore` in the console.<br>
Run `$ dotnet database update` in the console.<br>
Run `$ dotnet run` in the console
</details>
<br>

<details>
<summary><strong>For Testing</strong></summary>
Navigate to  
    <pre>PierresTreats.Solution
    ├── PierresTreats
    └── <strong>PierresTreats.Tests</strong></pre>

Run `$ dotnet test` in the console

</details>
<br>

This program was built using *`Microsoft .NET SDK 5.0.401`*, and may not be compatible with other versions. Your milage may vary.

## Known Bugs

* Any known bugs

## License

_Feel free to reach out via [Github](github.com.lcmpbll) to provide feedback on this project or to view my other projects._

[Copyright](/LICENSE) (c) _07-28-2022_ _Liam Campbell_
