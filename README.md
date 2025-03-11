![ตัวอย่า](https://github.com/Jessadaruk/SaveInformationSTD/blob/main/Student%20information/Image/Home.png)
# ระบบจัดการข้อมูลนักศึกษา

## คำอธิบาย

โปรแกรมนี้ออกแบบมาสำหรับอาจารย์เพื่อบันทึกข้อมูลนักศึกษา ซึ่งรวมถึงรหัสนักศึกษา ชื่อ นามสกุล สาขาวิชา และอาจารย์ที่ปรึกษา โปรแกรมนี้ยังช่วยให้อาจารย์ดูรายชื่อนักศึกษาภายใต้การให้คำปรึกษาของตนเอง และแสดงนักศึกษาที่ได้คะแนนสูงสุด

## หลักการ
การห่อหุ้ม (Encapsulation): คลาส Student ห่อหุ้มข้อมูลนักศึกษาและจัดเตรียมเมธอดเพื่อเข้าถึงและแก้ไขข้อมูล
การนามธรรม (Abstraction): คลาส Person จัดเตรียมการแสดงนามธรรมของบุคคล โดยซ่อนรายละเอียดที่ไม่จำเป็น
พหุสัณฐาน (Polymorphism): เมธอด ToString() ถูก override ในคลาส Student เพื่อจัดเตรียมการแสดงสตริงแบบกำหนดเอง
การสืบทอด (Inheritance): คลาส Student และ Advisor สืบทอดจากคลาส Person โดยนำคุณสมบัติและเมธอดทั่วไปมาใช้ใหม่


## คุณสมบัติ

* บันทึกข้อมูลนักศึกษา
* ดูรายชื่อนักศึกษาภายใต้การให้คำปรึกษา
* แสดงนักศึกษาที่ได้คะแนนสูงสุด
* แสดงรูปภาพเมื่อโหลดฟอร์ม
* ล้างข้อมูลที่ป้อน
* ป้องกันรหัสนักศึกษาซ้ำสำหรับอาจารย์คนเดียวกัน
* รับเฉพาะตัวเลขในช่องคะแนน

## วิธีใช้งาน

1.  ป้อนข้อมูลนักศึกษาในช่องข้อความ
2.  เลือกอาจารย์ที่ปรึกษาจากรายการดรอปดาวน์
3.  คลิกปุ่ม "บันทึก" เพื่อบันทึกข้อมูลนักศึกษา
4.  ดูรายชื่อนักศึกษาในกล่องรายการ
5.  คลิกที่นักศึกษาในกล่องรายการเพื่อดูข้อมูลอาจารย์ที่ปรึกษาของพวกเขา
6.  เลือกอาจารย์ที่ปรึกษาจากรายการดรอปดาวน์ที่สองและคลิก "แสดงข้อมูลอาจารย์" เพื่อดูนักศึกษาของพวกเขา
7.  นักศึกษาที่ได้คะแนนสูงสุดจะแสดงที่ด้านล่าง
8.  คลิกปุ่ม "ล้างข้อมูล" เพื่อล้างช่องป้อนข้อมูลทั้งหมด

## แผนภาพคลาส

```mermaid
classDiagram
    Person <|-- Student
    Person <|-- Advisor
    class Person{
        +string FirstName
        +string LastName
        +string Major
        +Person(string firstName, string lastName, string major)
    }
    class Student{
        +string StudentID
        +Advisor Advisor
        +double Score
        +Student(string firstName, string lastName, string major, string studentID, Advisor advisor, double score)
        +ToString() string
    }
    class Advisor{
        +List~Student~ Students
        +Advisor(string firstName, string lastName, string major)
        +AddStudent(Student student)
    }
    class ShowPic{
        +List~Student~ students
        +List~Advisor~ advisors
        +InitializeAdvisors(): void
        +addButton_Click(): void
        +clearButton_Click(): void
        +studentListBox_SelectedIndexChanged(): void
        +showAdvisorDataButton_Click(): void
        +scoreTextBox_KeyPress(): void
        +Form1_Load(): void
    }


