# Getting Started - Lab 1

In this lab you will ensure that everything is setup and running correctly.

## Steps
If you've made it this far hopefull you'll clone this repo :)

1. Build and run the project by running `dotnet run` from the `lab01\Web` directory.
   - If you prefer to use hot release you can run `dotnet watch` instead 
2. Navigate the port that the website is being hosted at. 
![Hosting](https://user-images.githubusercontent.com/8291593/164337374-91a850fb-bd0c-4b37-a328-3d349e7b70c1.png)
   - Ex: http://localhost:5017
3. You should see the Lemming Scheduling System (LeSS) now running.
![LeSS](https://user-images.githubusercontent.com/8291593/164337591-3be6cfbb-956a-4d55-b50d-3f378e416574.png)

You will notice that the LEmming Scheduling System is divided into two areas: the Lemming Dashboard and the Lemming Control Panel. 

The Lemming Dashboard displays the amount of work that has been completed, by each type of Lemming. 

The Lemming Control Panel allows the user to select the amount of work to be performed.

Before we start to use the LEmming Scheduling System, let’s open the browser’s Developer Tools.  To do so, press the F12 button, and select the Network tab in the Developer Tools panel.  This will allow us to monitor the performance of our Lemmings.

4. Open your browser's developer tools and schedule 10 Lemmings to Say Hello
![Hello10](https://user-images.githubusercontent.com/8291593/164364177-3191b678-238e-46d8-adf6-9625d37dcb56.png)

5. Observe the POST request to DoSayHelloJob.  Our Lemmings complete work in sequence to complete their jobs.
![image](https://user-images.githubusercontent.com/8291593/164364322-dda18663-6321-4a6e-8e4d-c9335909ef66.png)

>NOTE: Your timings may vary as our Lemmings simulate work.

You’ll notice in the screenshot above that our POST to DoSayHelloJob took nearly 53 seconds to complete.  During this time our application was blocked and no other Lemmings could be scheduled to work.

6. Once our Lemmings have completed their jobs, notice the statistics on the Lemming Dashboard:
![image](https://user-images.githubusercontent.com/8291593/164364671-638f062a-f131-4cda-8628-62860ac4e311.png)

7. To reset your statistics, click the “Run my Lemmings off a cliff…” link.

## Next Steps
Proceed to [Lab2](../lab02/README.md)