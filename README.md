**Kopsavilkums:**

&emsp;Šis ir .NET Web API projekts, kas paredzēts reāllaika kravas izsekošanas sistēmas izveidei. Sistēma izmanto sensorus, GPS un citas tehnoloģijas, lai nodrošinātu precīzu un savlaicīgu informāciju par kravas atrašanās vietu, stāvokli un paredzamo piegādes laiku. Tā ietver kravas reģistrāciju, maršruta plānošanu, reāllaika izsekošanu, paziņojumus un piegādes apstiprinājumu.

**Galvenie biznesa pielietojuma varianti:**

&emsp;**Reāllaika kravas izsekošana:** Nodrošina kravas atrašanās vietas un pārvietošanās uzraudzību reāllaikā, izmantojot GPS un citus sensorus.

&emsp;**Maršruta optimizācija un plānošana:** Palīdz dispečeriem efektīvi plānot maršrutus, samazinot piegādes laiku un izmaksas.

&emsp;**Stāvokļa uzraudzība un brīdinājumi:** Uzrauga kravas stāvokli (temperatūru, mitrumu, triecienus u.c.) un nosūta brīdinājumus, ja tiek pārsniegti noteikti sliekšņi.

&emsp;**Piegādes apstiprinājums un atskaites:** Reģistrē piegādes faktu, iegūst saņēmēja apstiprinājumu un ģenerē atskaites par piegādes laikiem un citiem parametriem.

&emsp;**Klientu apkalpošanas uzlabošana:** Nodrošina klientiem piekļuvi reāllaika informācijai par viņu kravas atrašanās vietu un stāvokli, uzlabojot apmierinātību un uzticību.


![UML_Project_TREB_Baltgalvis](https://github.com/user-attachments/assets/79a8746a-de8c-424b-a725-a4f7e2895200)


**Paskaidrojums:**

* **Project/**: Šī ir projekta saknes mape.
* **Controllers/**: Šajā mapē atrodas kontrolieri, kas apstrādā HTTP pieprasījumus.
    * `CargoController.cs`: Kravas reģistrācija un izsekošana.
    * `DispatcherController.cs`: Dispečera funkcionalitāte.
    * `ClientController.cs`: Klienta funkcionalitāte.
    * `ReportController.cs`: Piegādes atskaites.
* **Data/**: Šajā mapē atrodas `TransportContext.cs`, kas pārstāv datubāzes kontekstu.
* **Models/**: Šajā mapē atrodas klases, kas pārstāv datubāzes tabulas un domēna modeļus.
    * `Cargo.cs`: Kravas modelis.
    * `Sensors.cs`: Sensoru modelis.
    * `GPS.cs`: GPS datu modelis.
    * `Dispatcher.cs`: Dispečera modelis.
    * `Client.cs`: Klienta modelis.
    * `Route.cs`: Maršruta modelis.
    * `Notification.cs`: Paziņojumu modelis.
    * `DeliveryReport.cs`: Piegādes atskaites modelis.
* **Services/**: Šajā mapē atrodas servisi, kas satur biznesa loģiku.
    * `NotificationService.cs`: Paziņojumu sūtīšanas serviss.
* **`Program.cs`**: Šis ir programmas ieejas punkts.
* **`Startup.cs`**: Šis fails konfigurē lietojumprogrammas pakalpojumus un cauruļvadu.
* **`Appsettings.json`**: Šis fails satur konfigurācijas iestatījumus.
* **`Project.csproj`**: Šis ir projekta fails.
