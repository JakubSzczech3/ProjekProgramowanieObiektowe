using Projekt_Programowanie;
using Newtonsoft.Json;
String wczytywanie = "";
if (File.Exists("BazaDanych.json")) {
    wczytywanie = File.ReadAllText("BazaDanych.json");
}
else {
    wczytywanie = "{ \"bus\":[],\"pspec\":[],\"ciezarowka\":[],\"motor\":[],\"samochod\":[]}";

}

Baza baza = JsonConvert.DeserializeObject<Baza>(wczytywanie);
baza.Menu();
