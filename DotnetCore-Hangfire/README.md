The following labs are updated versions (updated for aspnetcore) of a workshop I gave at [Code PaLOUsa](https://www.codepalousa.com/) in 2016.

## What
In this set of Labs you will be updating the LEmming Scheduling System to be more efficient by implmenting methods for the Lemmings to perform their work asynchronously in the background. You will be utilizing Hangfire to facilitate the transition to asynchronous background job processing.

### Hangfire
[Hangfire](hangfire.io) is a framework for processing background jobs in dotnet applications.

## Why
Why Lemmings? Because they are cute and they love to work!

Why are we using Hangfire? Well because it just works. It's extremely easy to setup and start using as well as powerful in how you can implemntent the finer details.

## Labs
- [Getting Started - Lab 1](./lab01/README.md)
- [Installing Hangfire - Lab 2](./lab02/README.md)

> Originally these labs were designed to interacted with a database through Entitiy Framework, however, in this version of the labs the database dependencies have been removed and the database interactions are faked. Therefore, everytime the project is launched the Dashboard statistics will be reset.