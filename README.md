# quiz-desktop-app
Quiz app desktop application in .NET

A comprehensive quiz management system built with .NET WinForms that provides separate interfaces for faculty and students to manage and participate in quizzes.

---

## ✨ Features

### 🎓 Faculty Features

#### 📋 Quiz Management
- Create new quizzes with custom questions  
- Edit existing quiz content  
- Delete quizzes when no longer needed  
- Toggle quiz status (Live/Unlive)

#### 📊 Results & Analytics
- View detailed quiz results  
- Monitor student performance

#### 🔐 Account Management
- Secure login system  
- Safe logout functionality

### 👨‍🎓 Student Features

#### 📝 Quiz Participation
- Access all live/active quizzes  
- Interactive quiz-taking interface  
- Real-time quiz submission  

---

### Overview
<img width="796" height="482" alt="image" src="https://github.com/user-attachments/assets/59d8546d-741c-4f7c-930f-81f63ebcb1f8" />
<img width="947" height="608" alt="image" src="https://github.com/user-attachments/assets/49477f46-0478-43eb-a797-3f85787ef320" />
<img width="964" height="263" alt="image" src="https://github.com/user-attachments/assets/5c684a36-5c7e-41fa-8977-d304e7eceb33" />
<img width="1035" height="571" alt="image" src="https://github.com/user-attachments/assets/e26c42d0-17c1-40ea-aeca-3289b8ae4e8a" />
<img width="796" height="259" alt="image" src="https://github.com/user-attachments/assets/00f673e7-29d3-4e62-956d-422e44704c63" />
<img width="801" height="380" alt="image" src="https://github.com/user-attachments/assets/333ce955-81db-46d2-aef2-09ca347a5360" />


## 🛠 Technology Stack
- **.NET Framework** – Core application framework  
- **WinForms** – Desktop user interface  
- **SQL Server/LocalDB** – Database management  
- **C#** – Primary programming language

---

## ⚙️ Prerequisites
Before running this application, ensure you have:
- .NET Framework **4.7.2** or higher  
- **SQL Server LocalDB** or SQL Server Express  
- **Visual Studio 2019** or later (for development)  
- **Windows OS** (Windows 7 or later)

---

## 🚀 Installation & Setup

### 1. Clone the Repository
```bash
git clone https://github.com/iazimshaikh/quiz-desktop-app.git
cd quiz-desktop-app
```

### 2. Database Setup
- The application uses SQL Server LocalDB by default
- Database file (QuizApp.mdf) will be created automatically on first run
- Ensure SQL Server LocalDB is installed and running

### 3. Build the Project
- Open the solution (QuizApp.sln) in Visual Studio 
- Restore NuGet packages if prompted
- Build the solution (Ctrl + Shift + B)

### 4. Run the Application
- Set the startup project to the main application
- Press F5 or click Start to run

---
## 🧭 How to Use
### 🔑 Initial Login
- Launch the application
- The login page will appear 
- Enter your username and password (Temporary login details are given in login page)
- The system auto-detects user type (Faculty/Student) and redirects accordingly

## 👩‍🏫 For Faculty Users
### ✅ Creating a Quiz
- Navigate to "Create Quiz"
- Add questions, options, and correct answers
- Save the quiz

### 🛠 Managing Quizzes
- Use "Edit Quiz" to modify existing quizzes
- Toggle "Live/Unlive" status
- Use "Delete Quiz" to remove quizzes

### 📈 Viewing Results
- Access "View Results"
- Analyze quiz statistics and individual student responses

---
## 👨‍🎓 For Student Users
### 📝 Taking Quizzes
- Login with student credentials
- View available live quizzes
- Select a quiz and begin
- Submit answers upon completion

---
## 🚧 Future Enhancements
- Add question types (Multiple choice, True/False, Fill-in-the-blank)
- Implement timer functionality for quizzes
- Add export functionality for results (PDF/Excel)
- Include question bank management
- Add user registration system
- Implement quiz categories/subjects


### 👤 Author
**Azim Shaikh**  
GitHub: @iazimshaikh  
Email: azimrajshaikh@example.com

### 📄 License
This project is licensed under the MIT License.

### 📬 Support
If you encounter any issues or have questions:
- Check the Issues section
- Create a new issue with a detailed description
- Contact the developer via email


⭐ If you found this project helpful, please consider giving it a star on GitHub!
