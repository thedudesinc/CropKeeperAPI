# CropKeeperApi

Introduction
Crop Keeper is an application that will provide the user with the means to layout their gardening space. It will also create reminders for the user. It will be browser based and feature user accounts. Each user will have the ability to create new garden designs or load up existing designs. Once in the design stage, the user will be able to add and remove various markers, lines, and icons as they layout their garden. The application will also feature a task management system to assist the user with keeping track of their gardening tasks. The app will create tasks based on a garden layout. Those tasks will have reminders for when to perform them. Another potential feature would include access to a large database of information about plants.

Plan during winter. Set Tasks. Get Reminders.

# Developer Environment Initialization
These steps need to be completed before running the app for the first time.

1. Setup SQL Express on your local computer.
2. Install dotnet CLI
3. Install Entity Framework CLI.
5. Run `dotnet ef database update` in your terminal. If this command doesn't work, you may not have correctly install the above dependencies. 
6. Start debugging on the app (using F5 or clicking run in your IDE).

# Database Migration for Remote SQL Azure Instance
1. Run `dotnet ef migrations bundle --self-contained --verbose`
2. Run `.\efbundle.exe --connection '<insert remote connection string here>'`