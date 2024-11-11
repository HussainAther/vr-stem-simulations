# AI-Driven Personalized Learning Pathways

Welcome to the **AI-Driven Personalized Learning Pathways** project! This repository contains code and resources for creating an adaptive learning experience in VR, tailored to each student’s progress, preferences, and performance. By using AI to provide personalized pathways, real-time feedback, and adaptive VR modules, this project aims to enhance STEM education in immersive, interactive ways.

## Project Structure

```
ai-personalized-learning-pathways/
├── src/
│   ├── ai_model/              # Machine learning models for adaptation logic
│   ├── dashboard/             # Code for the Learning Insights Dashboard
│   ├── vr_adaptive_modules/   # Unity VR modules with adaptive features
│   └── utils/                 # Helper functions for data processing, analytics
├── docs/
│   └── README.md              # Detailed documentation
├── assets/
│   ├── icons/                 # Icons for the dashboard
│   └── models/                # 3D models used in VR simulations
├── tests/                     # Tests for ML models and VR modules
├── requirements.txt           # Dependencies for the project
├── .gitignore                 # Ignore unnecessary files
├── LICENSE                    # License (e.g., MIT)
└── README.md                  # Project overview and usage instructions
```

---

## Key Features

1. **Adaptive Learning Paths**: 
   - AI-driven suggestions for the next module, extra practice, or challenges based on each student's engagement and performance.
   
2. **Real-Time Feedback and Assessment**: 
   - Provides personalized quizzes and interactive questions within simulations, tracking student progress and tailoring feedback accordingly.
   
3. **Learning Insights Dashboard**: 
   - A dashboard for teachers and parents to monitor student progress, including AI-recommended next steps and visual data on engagement.

4. **Adaptive VR Experiences**: 
   - VR modules that adjust based on real-time performance data, providing hints or modifying challenges based on student needs.

---

## Installation

### Prerequisites

1. **Unity 2021 or later**: For VR module development.
2. **Python 3.8+**: For AI model development and dashboard back-end.
3. **Node.js**: For the front-end of the Learning Insights Dashboard.
4. **Firebase or AWS**: For storing student data and progress (optional but recommended for production).

### Steps

1. **Clone the repository**:
   ```bash
   git clone https://github.com/YourUsername/ai-personalized-learning-pathways.git
   cd ai-personalized-learning-pathways
   ```

2. **Install Python dependencies**:
   ```bash
   pip install -r requirements.txt
   ```

3. **Set Up Unity Project**:
   - Open Unity and import the `vr_adaptive_modules` folder from `src/` to start using the adaptive VR features.
   - Ensure that necessary Unity packages (e.g., XR Interaction Toolkit) are installed.

4. **Run the Dashboard**:
   - Navigate to the `src/dashboard/` directory.
   - Install dependencies and start the server:
     ```bash
     npm install
     npm start
     ```
   - The dashboard will be available at `http://localhost:3000`.

---

## Usage

### 1. Running the Adaptive Learning Model

The AI model in `src/ai_model/` recommends the next learning steps based on student data.

```bash
python src/ai_model/adaptive_learning_model.py
```

After training, this model can output recommendations as JSON, which will be used by the VR modules and dashboard.

### 2. Using the Learning Insights Dashboard

The dashboard provides teachers and parents with real-time insights into student progress. It displays:
- **Engagement Metrics**: Time spent, completion rates, and other data.
- **AI Recommendations**: Suggested next steps, areas of improvement, or challenges for the student.

Access the dashboard at `http://localhost:3000` once it’s running.

### 3. Interactive VR Modules

To experience the adaptive VR features, launch Unity and open the VR modules in `src/vr_adaptive_modules/`. Each module adapts based on user performance and progress, providing hints or altering difficulty in real-time.

---

## Testing

Unit and integration tests for the AI models and VR modules can be found in the `tests/` directory.

- **Run all tests**:
  ```bash
  python -m unittest discover tests
  ```

---

## Technologies Used

- **Python**: Machine learning model development and back-end logic.
- **Unity (C#)**: VR simulation and adaptive modules.
- **React**: Front-end for the Learning Insights Dashboard.
- **Firebase/AWS**: Data storage and real-time interaction tracking.

---

## Contributing

We welcome contributions to enhance and expand the personalized learning experience! Please submit a pull request or open an issue for any bugs or feature requests.

---

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

## Contact

For any questions, please reach out at [contact@alterlearning.com](mailto:contact@alterlearning.com).

---

Thank you for exploring **AI-Driven Personalized Learning Pathways**. Let’s make learning engaging and personalized for all!
