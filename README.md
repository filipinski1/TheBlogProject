TheBlogProject

A multi-user blog platform built with ASP.NET Core MVC, Entity Framework Core, and PostgreSQL. Users can create blogs, write posts with tags and images, and comment on posts, with role-based moderation.

Built during the CoderFoundry ASP.NET / C# bootcamp, then tested end to end as a QA project.


Features
Blogs and posts: create blogs, write posts with images and tags, and set a post's status (Incomplete, Preview Ready, Production Ready)
SEO-friendly URLs: each post gets a unique URL slug
Comments and moderation: a comment can store a moderated version and a reason (e.g. offensive language, hate speech), with a separate list of moderated comments
Authentication: ASP.NET Core Identity with email confirmation, password reset, and two-factor login
Roles: Administrator and Moderator, created automatically on startup
Contact form: sends email through Gmail SMTP using MailKit
Tech Stack
Layer	Technology
Backend	C#, ASP.NET Core MVC (.NET 5)
Data	Entity Framework Core (code-first migrations), PostgreSQL
Auth	ASP.NET Core Identity
Email	MailKit / MimeKit
Frontend	Razor views, Bootstrap
Architecture
Controllers: Blogs, Posts, Comments, Home
Services (injected through dependency injection, behind interfaces):
ISlugService: builds unique URL slugs
IImageService: image upload and display
IBlogEmailSender: email
DataService: seeds roles and the default users
Models: Blog, Post, Comment, Tag, BlogUser
QA Testing

I tested the app as a QA engineer:

Wrote a test plan and test cases covering authentication, roles, CRUD, and input validation
Found 10+ defects, including an authorization flaw and an XSS vulnerability
Checked UI actions against the database with SQL queries in pgAdmin
Running Locally

Requirements: .NET 5 SDK, PostgreSQL

Clone the repo:
git clone https://github.com/filipinski1/TheBlogProject.git
cd TheBlogProject
Store your connection string and mail password with User Secrets (they are never committed):
dotnet user-secrets init
dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Server=localhost;Port=5432;Database=TheBlogProject;User Id=postgres;Password=YOUR_PASSWORD"
dotnet user-secrets set "MailSettings:Password" "YOUR_GMAIL_APP_PASSWORD"
Apply the migrations and run the app:
dotnet ef database update
dotnet run
Roadmap
[ ] Upgrade to .NET 8
[ ] Add xUnit unit tests
[ ] Deploy to Azure App Service
