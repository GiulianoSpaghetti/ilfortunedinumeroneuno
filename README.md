[![.NET Uno Build](https://github.com/GiulianoSpaghetti/ilfortunedinumeroneuno/actions/workflows/dotnet-desktop.yml/badge.svg)](https://github.com/GiulianoSpaghetti/ilfortunedinumeroneuno/actions/workflows/dotnet-desktop.yml)

# ATTENZIONE
[https://gemini.google.com/app/e0ecacb2b5e87ed2](https://gemini.google.com/app/e0ecacb2b5e87ed2)

Il fortune almeno su debian è stato standardizzato ed è a libero accesso, per cui l'app viene dichiarata DEPRECATA su tale sistem


## Il fortune di numerone uno

Il fortune teller che parla italiano

:it: La prima incarnazione seria di un fortune teller in lingua non americana in uno platform. Il primo prodotto commerciale pubblicato per android che usa le api mysql invece delle api rest.


![Napoli-Logo](https://github.com/user-attachments/assets/485755c8-376c-4778-b9ba-80f6cb204142)

## Introduzione

Circa 15 anni fa era in voga in Italia una newsletter chiamata "Una barzelletta al giorno" della società buongiorno.
All'inizio pubblicavano citazioni, ma poi si sono messi a pubblicare citazioni non più coperte dal diritto d'autore.
Io me le sono conservate con lo specifico intento di creare il fortune coi cookie italiani.

## Il server

E' liberamente accessibile all'indirizzo numeronesoft.ddns.net porta 3306, con attualmente circa 500 massime, è mariadb.
Il server è stato ispezionato dalla FIMI e non presenta particolari problemi, per cui potete realizzare il vostro fortune personale, connettendovi con le librerie mysql in qualsiasi linguaggio vogliate, basta usare come user guest e come password nessuna.

## Come scaricare

## Per android

[![google](https://play.google.com/intl/it_it/badges/static/images/badges/it_badge_web_generic.png)](https://play.google.com/store/apps/details?id=org.altervista.numerone.fortuneuno)

## Per windows e debian

[![pling](http://numeronesoft.ddns.net:8080/images/pling.png)](https://www.pling.com/p/2315681)

## Prerequisti

### Windows
https://winstall.app/apps/Microsoft.DotNet.DesktopRuntime.10

### Debian

https://learn.microsoft.com/it-it/linux/packages

## Aggiornamenti
Per windows i package sono platform indepedent ed in IL, ma sono in dotnet 9 e 10, per cui è necessario ricompilare per evitare di avere il sistema spurio in caso di nuovo dotnet framework che comunque è necessario per l'avvio del software, che se aggiornato dovrebbe impedire lo shock sulle ventole.


## Bug noti
Su android quando si chiude non crasha, ma android la chiude come app non rispondente perché manca la connessione

## Donazioni (la banda costa, così come l'elettricità)
https://numerone.altervista.org/donazioni.php

## Note
Se in seguito ad aggiornamenti non installati i client dotnet riprendono a fare shock sulle ventole, provate a disinstallare il pacchetto, aggiornare all'ultimo framework e reinstallare. 
