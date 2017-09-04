import { HomeComponent } from "./views/home/home.component";
// import { ScoreboardComponent } from "./views/scoreboard/scoreboard.component";
// import { PlayerCardComponent } from "./views/playerCard/playerCard.component";

export const routes: any = [
  { path: "", component: HomeComponent },
  { path: "home", component: HomeComponent }
];

export const navigatableComponents: any = [
  HomeComponent
];