using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;
public class ProblemScene : MonoBehaviour
{

    [SerializeField] private Button problem1;
    [SerializeField] private Button problem2;
    [SerializeField] private Button problem3;
    [SerializeField] private Button problem4;
    [SerializeField] private Button problem5;
    [SerializeField] private Button problem6;
    [SerializeField] private Button problem7;
    [SerializeField] private Button problem8;
    [SerializeField] private Button problem9;

    private void Start()
    {
        problem1.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(1);
        });

        problem2.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(2);
        });

        problem3.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(3);
        });

        problem4.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(4);
        });

        problem5.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(5);
        });

        problem6.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(6);
        });

        problem7.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(7);
        });

        problem8.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(8);
        });

        problem9.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(9);
        });
    }

}