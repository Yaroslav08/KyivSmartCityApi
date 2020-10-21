# Kyiv Smart City Api [unofficial]
Бібліотека, яка надає можливість читати дані з KyivSmartApi, котрі прив'язані до вашого акаунту.
## Базове використання
### Ініціалізація клієнта
```csharp
KyivApiClient client  = new KyivApiClient("{your_accesstoken}")
```
### Отримати новий токен
```csharp
var tokenModel = await client.RefreshAuth();
```
### Завантажити заголовок
```csharp
var headline = await client.GetHeadlineAsync();
```
### Завантажити новини
```csharp
var feeds = await client.GetFeedsAsync();
```
### Завантажити новину по Id
```csharp
var feed = await client.GetFeedAsync("{feed_id}");
```
### Додати смарт картку (якщо операція успішно, тоді повернется об'єкт SmartCard)
```csharp
var addCard = await client.AddSmartCard(new CreateSmartCardModel
{
      Name = "SmartCard",
      Number = "100003333333",
      Pin = "3113"
});
```
### Завантажити інформацію про свої смарт картки
```csharp
var cards = await client.GetTravelCardsAsync();
```
### Завантажити інформацію про смарт картку
```csharp
var user = await client.GetSmartCardInfoAsync(Id);
```
### Завантажити інформацію про історію поїздок смарт картки
```csharp
var user = await client.GetTravelCardHistoryAsync({card_id});
```
### Завантажити інформацію про користувача
```csharp
var user = await client.GetUserAsync();
```
### Завантажити інформацію про документи
```csharp
var documents = await client.GetDocumentsAsync();
```
### Завантажити інформацію про документ по його Id
```csharp
var document = await client.GetDocumentAsync({document_id});
```
### Завантажити інформацію про банківські картки
```csharp
var bankcards = await client.GetBankCardsAsync();
```
### Видалення банківської картки по Id (експериментальний метод)
```csharp
var куігде = await client.RemoveBankCardAsync({bank_card_Id});
```
### Завантажити інформацію про телефон (MasterPass)
```csharp
var phone = await client.GetMasterpassPhone();
```
### Завантажити інформацію про домашні адреси
```csharp
var addresses = await client.GetAddressesAsync();
```
