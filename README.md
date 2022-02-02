# Autók
A kapott kezdő kód nem felel meg az open-closed alapelvnek. Illetve ha `cars` lista `null` akkor hibára fut. 
A `CalculateFuel` metódus feladata, hogy a versenyhez szükséges összes üzemanyag mennyiségét adja vissza. 
A `Race` konstruktora paraméterként a körök számát és az autók listáját kapja meg. 
Egy `Ford` egy kör alatt 4 egység üzemanyagot fogyaszt. 
Egy `Ferrari` egy kör alatt 2 egység üzemanyagot fogyaszt.

## Feladat 1:
Refactoráld a kódot úgy hogy megfeleljen az open-closed alapelvnek. Ehhez el kell tüntetned a kódból az is használatát.

## Feladat 2:
Oldd meg, hogy ha a `cars` lista `null` akkor se fusson hibára a kód. Ilyenkor adjunk vissza `0`-át.

## Egyéb kritérium:
Ne módosítsd az osztályok helyét és ne hagyj kommentet a kódba!
