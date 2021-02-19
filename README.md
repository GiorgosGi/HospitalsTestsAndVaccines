# HospitalsTestsAndVaccines

This is a working asp.net MVC app, created as a group project, while attending coding bootcamp MchlplsM#12 at PeopleCert Education.
The members of our reams included:
-Marios Michalopoulos: https://github.com/MchlplsM
-Haris Arapakis: https://github.com/harisarapakis
-Konstantinos Skylakos: https://github.com/Doggy96

HospitalsTestsAndVaccines web app supports patient registration for scheduling appointments for services provided by a clinic, and also managing the appointments by the clinic manager.

Frameworks - Libraries

-ASP.NET MVC (version 5)
-Entity Framework
-ASP.NET SignalR
-Web Grease
-Stripe.net 
-DHTMLX scheduler 
-Automapper

Running Project:
Open the project with Visual Studio.
In web.configfile change the connection string according to your system.

In package manager console run the following commands
- enable-migrations
- add-migration "Initial"
- update-database

Τhen run again add-migration and in the created file at "public override void Up()" add the data that include initial user-roles, users and products.
