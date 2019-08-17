//
//  MathViewController.swift
//  MathAppProgram
//
//  Created by Jessica Alexander on 5/30/19.
//  Copyright © 2019 Jessica Alexander. All rights reserved.
//

import Foundation
import UIKit
class MathViewController: UIViewController{
    @IBAction func btnNewProblem(_ sender: UIButton) {
        let num1:UInt32? = arc4random() % 100
        var num2:UInt32? = arc4random() % 100
        let symbol:UInt32? = arc4random() % 4
        
        switch(symbol)
        {
        case 0:
            lblSymbol.text = "+"
            lblNum1.text = String(num1!)
            lblNum2.text = String(num2!)
            correctAnswer = num1! + num2!
        case 1:
            lblSymbol.text = "-"
            
            
            if num1! < num2!
            {
                lblNum2.text = String(num1!)
                lblNum1.text = String(num2!)
                correctAnswer = num2! - num1!
            }else{
                lblNum1.text = String(num1!)
                lblNum2.text = String(num2!)
                correctAnswer = num1! - num2!
            }
        case 2:
            lblSymbol.text = "*"
            lblNum1.text = String(num1!)
            lblNum2.text = String(num2!)
            correctAnswer = num1! * num2!
            if (num2! == 0)
            {
                num2 = 1
            }
        case 3:
            lblSymbol.text = "/"
            lblNum1.text = String(num1!)
            lblNum2.text = String(num2!)
            correctAnswer = num1! / num2!
            if (num2! == 0)
            {
                num2 = 1
            }
        default:
            lblMessage.text = "Something went wrong. Please contact your system administrator"
        }
        
    }
    @IBAction func CheckAnswer(_ sender: UIButton) {
        view.endEditing(true)
        let answer:UInt32? = UInt32(txtAnswer.text!)
        
        if(answer == correctAnswer)
        {
            lblMessage.text = "Congratulations! You are correct."
            corrects += 1
            lblCorrect.text = "\(String(describing: corrects))."
        }
        else
        {
            lblMessage.text = "Wrong. The correct answer was \(String(describing: correctAnswer))."
            
            wrongs += 1
            lblWrong.text = "\(String(describing: wrongs))."
        }
    }
    
    
@IBAction func txtAnswerReturn(_ sender: UITextField) {
    _ = sender.resignFirstResponder()
}

    @IBOutlet weak var lblSymbol: UILabel!
    @IBOutlet weak var lblNum1: UILabel!
    @IBOutlet weak var lblNum2: UILabel!
    @IBOutlet weak var lblMessage: UILabel!
    @IBOutlet weak var lblCorrect: UILabel!
@IBOutlet weak var txtAnswer: UITextField!
    @IBOutlet weak var lblWrong: UILabel!
    var correctAnswer:UInt32? = 0
    var corrects = 0
    var wrongs = 0
    
    override func touchesBegan(_ touches: Set<UITouch>, with event: UIEvent?) {
    view.endEditing(true)
}

override func viewDidLoad() {
    lblCorrect.text = String(corrects)
    lblWrong.text = String(wrongs)
}
}
