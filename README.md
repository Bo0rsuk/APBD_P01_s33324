# OPIS PROJEKTU
Jest to aplikacja konsolowa napisana w języku C# (C# Console App) jako praca na ćwiczenia nr 3 z 2526Lwis.APBD
Symuluje ona działanie systemu do zarządzania wypożyczalnią sprzętu (laptop, camera, headset) dla osób (student, employee).
System wspiera następujace funkcje:
* dodawanie nowych ludzi i sprzętu
* wypożyczanie sprzętu
* wyświetlanie ludzi, sprzętu, wypożyczeń z możliwością filtrowania po konkretnych parametrach (np dostępne dla sprzętu)
* pilnowanie reguł biznesowych takich jak kara za przeterminowanie wypożyczenia lub maksymalne limity wypożyczeń dla osoby

# Ogólna struktura rozwiązania
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
Udostępnia w stylu repozytorium metody CRUD (no prawie, nie wszystkie)

## DataModels
To projekt zawierający implementację wszystkich modeli używanych w programie.
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

## BusinessLogic
To projekt odpowiadający Business Layer odpowiedzialną za logikę biznesową aplikacji.
Zawiera klasy:
* IBusinessLogic - interfejs
* BusinessLogic - implementacja

# Architektura rozwiązania
Mój zamysł polegał na zrealizowaniu warstwowej infrastruktury aplikacji. Fizyczny podział na projekty wewnątrz solucji był pomysłem na uwidocznienie tych warstw.
Z racji na ograniczoną wiedzę (jestem dopiero w połowie książki Roberta C. Martina) jak i brak konieczności implementacji wszystkich warstw postanowiłem szczególnie zadbać o odpowiednie zrealizowanie idei zależności pomiędzy dwoma najbardziej rozwiniętymi warstwami w moim rozwiązaniu.
Dostęp zarówno do BuisnessLogic jak i DataRepository odbywa się przez interfejsy, co tworzy luźne powiązania (loose coupling) i umożliwia wymianę implementacji tych komponentów na inną (gdy np. zmienią się nam reguły biznesowe).
