1) Obecný scénář mojí aplikace:
	Tvorba aplikace pro tajemníka ústavu (školy).
	
		* Tajemník může vytvářet a upravovat studijní plány.
		* Studijní plány se skládají z předmětů, které tajemník může přidávat či odebírat ve formuláři "Studijní plány".
		* Každý předmět má svůj název, zkratku, vyučujícího, způsob výuky, způsob zakončení, kredity, maximální počet
		  studentů a jazyk, ve kterém je vyučován, povinný/nepovinný.
		* Pokud se tajemník snaží přidat předemět s již existijící zkratkou (primární klíč), nevytvoří se a tajemník bude
		  na shodu upozorněn.
	  
		* Předměty vyučují zaměstnanci, které tajemník eviduje ve formuláři "Zaměstnanci".
		* O zaměstnanci lze evidovat jméno a příjmení, email, telefon, druh úvazku, pracovní body za výuku.
		* Jeden zaměstnanec může vyučovat více předmětů.
		* Pracovní body za výuku určuje tajemník.
	
		* Tajemník spravuje počty studentů vzhledek k jimi studovaným oborům ve formuláři "Počty studentů".
		* Počty studentů se kategorizují dle typu studia (Bc, Mgr...), studovaného oboru, formy studia (denní, komb...),
		  ročníku, semestru, studijního jazyku.
		  
		* Tajemník si ve formluláři "Pracovní štítky" stiskem tlačítka "Generuj" vygeneruje pracovní štítky zaměstnanců.
		* Pracovní štítky jednotlivých zaměstnanců jsou uloženy ve formátu .csv.		
		* Vybraný pracovní štítek lze zobrazit i přímo ve formuláři.
		* Pracovní štítky lze po změně počtu studentů aktualizovat tlačítkem "Aktualizuj pracovní štítky".
		* Pracovní štítky zobrazují údaje o vyučovaných předmětech, počtech přednášek, cvičení..., počtu pracovních bodů.				
	

2) Otázky na které se chci zeptat:
	* Pro ukládání dat je potřba použít SQL databázi nebo stačí XML?
	* Pracovní štítky - uloží se do csv a z csv se budou také načítat, stačí to takto?
	* Pracovní body - nerozumím tomu, jak to s nimi je nebo jak se rozdělují. Každý předmět má jiný počet pracovních bodů,
	  jejich počet určuje, zda má předmět cvičení, semináře, kolik ho studuje studentů atp? Co má tedy obsahovat xml
	  soubor upravující váhu pracovních bodů? Kolik bodů je za vyzkoušeného studenta, kolik za předmět, který má cvičení atp?


3) Technologie, které chci použít:
	* Windows Forms - .NET framework pro tvorbu formulářů
	* Class Library - knihovna tříd bude obsahovat jednotlivé třídy dle zadání
	* SQL Database / XML? - ukládání dat
	* .csv - pro ukládání pracovních štítků
	* Linq -  jazyk .NET Frameworku pro dotazování
	* Interface - pro skupiny souvisejících funkcí
	* Events - události a reakce na ně
		