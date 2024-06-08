# Spengergram 🥳

## Beschreibung
Spengergram ist eine kompakte Social-Media-App, die es Nutzer ermöglicht, sich zu registrieren, anzumelden und Fotos zu teilen.
Nutzer können Beiträge auf einer Timeline durchsuchen und liken.
Weitere Kernfunktionen umfassen das Hinzufügen und Verwalten von Freundschaften sowie ein separates Admin-Dashboard.
Diese vereinfachte Version von Instagram dient als praxisorientiertes Lernprojekt, in dem Studierende grundlegende und fortgeschrittene Techniken der App-Entwicklung in einem realen Kontext anwenden können.

## Motivation
Das Ziel des Projekts ist es, den Studierenden eine praxisnahe Erfahrung zu bieten, indem sie den gesamten Entwicklungsprozess einer App von der Konzeption bis zur Produktionsreife durchlaufen.
Dies ermöglicht es ihnen, sowohl theoretisches Wissen als auch praktische Fähigkeiten in der Entwicklung von Web- und Mobile-Anwendungen anzuwenden.
Das Projekt dient zudem als Musterbeispiel, das die Studierenden für zukünftige Diplomprojekte und berufliche Vorhaben nutzen können.

## Lehrmethodik
* Flipped Class Room
* +- 10 große Lehrziele / Semester
* Für jedes Lehrziel einen Foliensatz, der im Vorhinein ausgeteilt wird.
* Individuelle Vorbereitung der Studierenden ergibt eine grundlegende Mitarbeitsbewertung.
* Für jedes Lehrziel vorstellen, zu absteigenden Prozentsätzen vorkodieren, Abschluss muss durch die Studierenden erfolgen, Beurteilung durch Pull-Request. Auflösung im Nachhinein.

## Bewertung
* **Wöchentliche Pull-Requests:** Die Studierenden müssen jede Woche einen Pull-Request einreichen. Die Qualität dieser Pull-Requests ist ein zentrales Bewertungskriterium und reflektiert die kontinuierliche Mitarbeit und technische Umsetzung des Projekts.
* **Praktische Leistungsüberprüfung (PLÜ):** Zusätzlich zur laufenden Bewertung der Pull-Requests findet pro Semester eine PLÜ statt, die darauf abzielt, das erlernte Wissen und die praktischen Fähigkeiten der Studierenden zu bewerten.
* **Referate und aktive Teilnahme:** Als ergänzende Bewertungsoption können die Studierenden Referate zu spezifischen Themenbereichen halten. Zudem wird die aktive Teilnahme am Unterricht bewertet, um Engagement und Beteiligung im Lernprozess zu fördern.

## Lehrziele POS
### Wintersemester (Matura Main-Facts)
  * Umsetzung einer Todo-App
  * C# Basics / .NET Basics
  * LinQ
  * OR-Mapper
  * 3-Layer Architecture
  * Basic-Patterns (Repository, Builder)
  * Unit Tests
  * API-Design

### Sommersemester
  * Umsetzung der Spengergram-App
  * Clean Architecture
  * Authentication
  * Authorization
  * Fluent API
  * CQRS
  * SOLID
  * Advanced-Patterns (Mediator, Template, ...)
  * Separation of Concern
  * Middleware
  * Caching
  * TDD, BDD

## Lehrziele WMC
### Wintersemester (Matura Main-Facts)
  * Umsetzung einer Todo-App (Cross platform: Web/Mobile)
  * JavaScript Recap (Promises, Async/Await, Destructuring, Spread Operator, ...)
  * Typescript Basics
  * React / React Native Basics
  * JSX, Props, State, Hooks, Event Handling,
  * Components, Services, Routing, Forms (VWA)
  * Component-Patterns (Higher Order, Render-Props, Container, Provider)
  * Unit Tests, End-to-End Tests (VWA)
  * Design System in Figma, UI/UX Regeln (VWA)
  * Component-Frameworks (Native Base)
  * Rest API, Mocking API

### Sommersemester
  * Umsetzung der Spengergram-App (Cross platform: Web/Mobile)
  * NX Mono Repository 
  * NX Lib Architecture (UI, Data-Access, Features, Util)
  * Advanced Component-Patterns (Container, Provider, Composition)
  * Statement Management (VWA)
  * Native Camera, Gallery, File-Upload, File-Download
  * Native Features (Push-Notifications, Storage, Battery, Geolocation, ...)
  * Infinity Scroll
  * Offline First, Offline Sync
  * Web Security / Mobile Security (VWA)

## Spengergram-App
### Spengergram-App Umsetzung
  * **DevOps-Einführungsphase:** Die Entwicklung der Spengergram-App beginnt mit einer intensiven DevOps-Phase, die als Grundlage für die weitere App-Entwicklung dient.
  * **Ziel der DevOps-Phase:** Diese Phase zielt darauf ab, die Entwicklungsprozesse zu optimieren, um eine effiziente und agile Implementierung der App-Funktionalitäten zu gewährleisten.


### DevOps-Komponenten
  * **Versionskontrolle:** Einsatz von Git und GitHub zur Verwaltung des Projektquellcodes und zur Zusammenarbeit im Team.
  * **Continuous Integration und Continuous Deployment (CI/CD):** Nutzung von GitHub Actions zur Automatisierung von Tests, Builds und Deployments.
  * **Containerisierung und Orchestrierung:** Verwendung von Docker für die Containerisierung der Anwendung und Kubernetes für das Management der Container in Produktionsumgebungen.

### DevOps-Voraussetzungen
  * **Agile Softwareentwicklung:** Anwendung agiler Methoden mit Jira, Confluence, User Stories

### Deployment
  * Es wird ein Deployment auf einem Cloud-Provider (z.B. AWS, Azure, Google Cloud) angestrebt.
  * Oder ein Deployment auf einem eigenen Server (z.B. Hetzner, ...)

## Spengergram-Features
* Registrierung
* Anmeldung / Abmeldung
* Anzeigen der Timeline mit Posts als Infinite Scroll
* Filtern, Sortieren und Suchen von Posts
* Post erstellen, liken
* Freundschaftsanfragen senden, annehmen, ablehnen
* Kleines Admin-Dashboard für Statistiken und Benutzerverwaltung


## Lehrziele 1 bis 10 pro Semester / Fach

Werden über den Sommer ausgearbeitet.


## Appendix: Matura Themen
#### 1. Architektur von Web- und Mobile-Anwendungen
- Frontend/Backend Aufteilung
- REST, RESTful API
- Komponentenkonzept (Clientseitig)
- Controller, Services im Backend
- Testen

#### 2. Datenmanagement und Persistenz in Web- und Mobile-Anwendungen
- CRUD Operationen und deren Abbildung im Frontend
- CRUD Operationen und deren Abbildung im Backend
- Validierung (clientseitig, serverseitig)

#### 3. Development, Deployment und Betrieb von Web- und Mobile-Anwendungen
- Containertechnik
- Cloudprovider
- Continuous deployment

#### 4. Frameworks im Bereich der Web- und Mobile-Anwendungen
- Komponentenkonzept (Clientseitig) in Hinblick auf Vue.js, Angular, ...
- Entwicklungswerkzeuge
- State Management
- Andere Themen aus Vue, Angular, … die behandelt wurden.

#### 5. Sicherheit in Web- und Mobile-Anwendungen
- Authentication und Authorization
- Implementierung im Backend
- Implementierung im Frontend
- Angriffsvektoren im Bereich der Webapplikationen

#### 6. User Experience & User Interfaces in Web- und Mobile-Anwendungen
- Responsive und Adaptive Design
- Auszeichnungssprachen für die Gestaltung
- Formulargestaltung
- Barrierefreies Webdesign
