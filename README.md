# OPIS PROJEKTU
Jest to aplikacja konsolowa napisana w języku C# (C# Console App) jako praca na ćwiczenia nr 3 z 2526Lwis.APBD
Symuluje ona działanie systemu do zarządzania wypożyczalnią sprzętu (laptop, camera, headset) dla osób (student, employee).
System wspiera następujace funkcje:
* dodawanie nowych ludzi i sprzętu
* wypożyczanie sprzętu
* wyświetlanie ludzi, sprzętu, wypożyczeń z możliwością filtrowania po konkretnych parametrach (np dostępne dla sprzętu)
* pilnowanie reguł biznesowych takich jak kara za przeterminowanie wypożyczenia lub maksymalne limity wypożyczeń dla osoby

# Architektura projektu
Solucja jest podzielona na 4 główne projekty w celu rozdzielenia kodu na komponenty o wspólnej roli:
* RentalApp
* DataProcessing
* DataModels
* BusinessLogic

## Rental App
To projekt zawierający jednostkę uruchomieniową (z główną metodą main) Program.cs, w której zawarte jest demo działania aplikacji.

## DataProcessing
To swego rodzaju Persistance Layer połączony z Database Layer, ponieważ pełni funkcję utrwalania jak i przechowywania danych.
Zawiera klasy takie jak:
* IDataRepository - interfejs
* DataRepository - implementacja

## DataModels
To projek zawierający implementacje wszyskich modeli używanych w programie.
W katalogu *abstract* znajduja się bazowe klasy abstrakcyjne:
* Person
* Equipment
Z tych klas bazowych dziedziczą klasy:
* dla Person
  * Student
  * Employee
* dla Equipment
  * Laptop
  * Camera
  * Headset
Te klasy posiadają odpowiednie properties.
