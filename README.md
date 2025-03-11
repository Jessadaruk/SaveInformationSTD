# ระบบจัดการข้อมูลนักศึกษา

## คำอธิบาย

โปรแกรมนี้ออกแบบมาสำหรับอาจารย์เพื่อบันทึกข้อมูลนักศึกษา ซึ่งรวมถึงรหัสนักศึกษา ชื่อ นามสกุล สาขาวิชา และอาจารย์ที่ปรึกษา โปรแกรมนี้ยังช่วยให้อาจารย์ดูรายชื่อนักศึกษาภายใต้การให้คำปรึกษาของตนเอง และแสดงนักศึกษาที่ได้คะแนนสูงสุด

## หลักการ
Encapsulation (การห่อหุ้ม): มีการสร้างคลาส Person เพื่อเป็นคลาสแม่ และมีคลาสลูกคือ Student และ Advisor มีการกำหนดแอททริบิวต์ต่างๆ ให้กับคลาส และมีการกำหนดขอบเขตการเข้าถึงข้อมูลด้วย private หรือ public
Inheritance (การสืบทอด): คลาส Student และ Advisor สืบทอดคุณสมบัติจากคลาส Person ทำให้สามารถนำแอททริบิวต์และเมธอดของคลาส Person มาใช้ได้
Polymorphism (พหุสัณฐาน): มีการใช้เมธอด ToString() ในคลาส Student เพื่อ override เมธอด ToString() ของคลาส Object ทำให้สามารถกำหนดรูปแบบการแสดงผลข้อมูลของอ็อบเจ็กต์ Student ได้ตามต้องการ
Abstraction (การนามธรรม): มีการสร้างคลาส Person ซึ่งเป็นคลาสแม่ที่มีแอททริบิวต์และเมธอดทั่วไป ทำให้คลาสลูก Student และ Advisor ไม่จำเป็นต้องมีแอททริบิวต์และเมธอดเหล่านี้ซ้ำ มีการซ่อนรายละเอียดที่ไม่จำเป็นในการทำงานของโปรแกรม เช่น การทำงานของเมธอด AddStudent() ในคลาส Advisor


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


