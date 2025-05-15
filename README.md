Księgarnia — Aplikacja Desktopowa WinForms

Księgarnia - to aplikacja desktopowa napisana w języku C# z wykorzystaniem technologii Windows Forms. Umożliwia zarządzanie zasobami księgarni, takimi jak pracownicy, zakupy, raporty i historia zakupów. Aplikacja wykorzystuje lokalny 'DataSet' ('KsiegarniaDataSet5.xsd') do komunikacji z bazą danych.

---

Moduły aplikacji

Aplikacja podzielona jest na formularze, z których każdy odpowiada za inną funkcjonalność:

- Form1.cs – Główny formularz startowy.
- Pracownicy.cs – Przeglądanie i edycja danych pracowników.
- DodajPracownika.cs – Formularz do dodawania nowego pracownika.
- Zasoby.cs – Przeglądanie zasobów.
- DodajZasoby.cs – Zarządzanie zasobami.
- Zakupy.cs – Obsługa zakupów książek.
- HistoriaZakupow.cs – Podgląd historii transakcji.
- Raporty.cs – Generowanie raportów z danych.

---

Struktura danych

Dane przechowywane są w silniku bazy danych SQL Server Management Studio, do którego aplikacja odwołuje się przez TableAdapters. Struktura danych zdefiniowana jest w pliku:

- 'KsiegarniaDataSet5.xsd' – zawiera tabele, kolumny i połączenia z bazą.

---

Funkcje aplikacji

- Przeglądanie, dodawanie i edytowanie danych pracowników.
- Obsługa zakupów i historii transakcji.
- Zarządzanie zasobami księgarni.
- Proste raportowanie i przegląd danych.
- Obsługa błędów i walidacja pól.

---

Jak uruchomić

1. Otwórz projekt w Visual Studio.
2. Upewnij się, że 'TableAdaptery' są poprawnie skonfigurowane w 'KsiegarniaDataSet5.xsd'.
3. Kliknij Start (F5), aby uruchomić aplikację.

---

Wymagania systemowe

- Visual Studio 2019 lub nowszy
- .NET Framework 4.7.2 lub nowszy


---

## 📖 Autor

Projekt stworzony jako część praktyki/studiów w zakresie **informatyki ekonomicznej** z naciskiem na integrację z bazą danych i zarządzanie informacją.

