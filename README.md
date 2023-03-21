# KpopZtation_GroupB
tugas lab psd kpopztation ddd

Update Progress, yang sudah dikerjakan:
- Model
- Database query
- Factory semua tabel
- Masterpage
- UI untuk insert/update yg ada formnya

To Do yang belum dikerjakan:
- UI/Tampilan untuk view
- Validasi dan CRUD
- Session/Cookie, Roles

Penjelasan layer:
- Controller: buat logic kayak validasi, session/cookie, panggil handler
- Handler: business logic kayak generate ID, panggil repository
- Repository: hubungin ke DB melalui model, CRUD, panggil model dan factory
- Factory: buat object kayak create new node di DS
