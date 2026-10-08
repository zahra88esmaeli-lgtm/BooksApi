<div dir="rtl">

# BooksApi

[English](README.md)

یک Web API ساده با ASP.NET Core برای مدیریت کتاب‌ها، ساخته‌شده با C#، نسخه .NET 10، EF Core و SQLite.

## امکانات

- عملیات کامل CRUD برای کتاب‌ها
- ذخیره داده‌ها با EF Core و SQLite
- اعتبارسنجی ورودی با Data Annotations
- سرویس و کنترلر async
- فایل `.http` آماده برای تست درخواست‌ها

## تکنولوژی‌ها

- C# / .NET 10
- ASP.NET Core Web API
- Entity Framework Core
- SQLite

## Endpointها

| متد    | آدرس             | توضیح                   |
|--------|------------------|-------------------------|
| GET    | `/api/book`      | دریافت همه کتاب‌ها      |
| GET    | `/api/book/{id}` | دریافت یک کتاب با شناسه |
| POST   | `/api/book`      | افزودن کتاب جدید        |
| PUT    | `/api/book/{id}` | ویرایش کتاب             |
| DELETE | `/api/book/{id}` | حذف کتاب                |

## مدل کتاب

| فیلد            | نوع      | قوانین                                          |
|-----------------|----------|-------------------------------------------------|
| `id`            | int      | توسط دیتابیس ساخته می‌شود                        |
| `title`         | string   | اجباری                                          |
| `author`        | string   | اجباری                                          |
| `publishedDate` | DateTime | فرمت `yyyy-MM-dd`، بین سال ۱۰۰۰ تا ۲۱۰۰ میلادی |

## نحوه اجرا

1. مخزن را clone کنید:
   ```
   git clone <https://github.com/zahra88esmaeli-lgtm/BooksApi.git>
   ```
2. solution را در Visual Studio باز کنید (یا از ترمینال استفاده کنید).
3. دیتابیس را بسازید:
   ```
   dotnet ef database update
   ```
   (یا در Package Manager Console دستور `Update-Database` را بزنید)
4. پروژه را اجرا کنید:
   ```
   dotnet run
   ```
5. با درخواست‌های داخل فایل `.http`، API را تست کنید.

## نمونه درخواست

```http
POST /api/book
Content-Type: application/json

{
  "title": "Clean Code",
  "author": "Robert Martin",
  "publishedDate": "2020-02-05"
}
```

## نمونه اعتبارسنجی

درخواست نامعتبر (عنوان خالی و تاریخ خارج از بازه) پاسخ `400 Bad Request` همراه با لیست خطاها برمی‌گرداند:

```json
{
  "title": "",
  "author": "Robert Martin",
  "publishedDate": "3000-01-01"
}
```

</div>
