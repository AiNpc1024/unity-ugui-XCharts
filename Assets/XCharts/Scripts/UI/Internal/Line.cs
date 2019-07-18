﻿using UnityEngine;

namespace XCharts
{
    [System.Serializable]
    public class Line
    {
        public enum StepType
        {
            Start,
            Middle,
            End
        }
        [SerializeField] private float m_Tickness;
        [SerializeField] private bool m_Point;
        [SerializeField] private float m_PointWidth;
        [SerializeField] private float m_PointSelectedWidth;
        [SerializeField] private bool m_Smooth;
        [SerializeField] [Range(1f, 10f)] private float m_SmoothStyle;
        [SerializeField] private bool m_Area;
        [SerializeField] private bool m_Step;
        [SerializeField] private StepType m_StepType;

        public float tickness { get { return m_Tickness; } set { m_Tickness = value; } }
        public bool point { get { return m_Point; } set { m_Point = value; } }
        public float pointWidth { get { return m_PointWidth; } set { m_PointWidth = value; } }
        public float pointSelectedWidth { get { return m_PointSelectedWidth; } set { m_PointSelectedWidth = value; } }
        public float smoothStyle { get { return m_SmoothStyle; } set { m_SmoothStyle = value; } }
        public bool smooth { get { return m_Smooth; } set { m_Smooth = value; } }
        public bool area { get { return m_Area; } set { m_Area = value; } }
        public bool step { get { return m_Step; } set { m_Step = value; } }
        public StepType stepTpe { get { return m_StepType; } set { m_StepType = value; } }

        public static Line defaultLine
        {
            get
            {
                var line = new Line
                {
                    m_Tickness = 0.8f,
                    m_Point = true,
                    m_PointWidth = 2.5f,
                    m_PointSelectedWidth = 5.5f,
                    m_Smooth = false,
                    m_SmoothStyle = 2f,
                    m_Area = false,
                    m_Step = false,
                    m_StepType = StepType.Middle
                };
                return line;
            }
        }
    }
}