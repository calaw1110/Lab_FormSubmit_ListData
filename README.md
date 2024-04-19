# Lab_FormSubmit_ListData
## 實驗 Form Submit 接收 List Data 情況紀錄
### 使用 Asp .Net Core MVC
### 程式碼紀錄
* Model 定義Model、ViewModel

![image](https://imgur.com/BhM6dBm.jpg)

* Controller 建立一個方法給 Form Submit Endpoint

![image](https://imgur.com/P3xpyRN.jpg)

* View 

![image](https://imgur.com/BrQBPq7.jpg)


### 狀況 使用 JS 動態新增欄位，並且刪除後無重新排序

#### 產生前端測試畫面
![image](https://imgur.com/zcJoLRN.jpg)
![image](https://imgur.com/sac9TZa.jpg)

`因使用 Form Submit 機制，建立input時 使用 name=CarList[index].Name 送資料到後端，
才能使用 CarListViewModel Binding 接收資料`

#### 後端接收資料情況

![image](https://imgur.com/OXyF4gU.jpg)

![image](https://imgur.com/gKk3LOj.jpg)

`僅接收到 前三筆 從 0 開始的連續資料`
