/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode() : val(0), next(nullptr) {}
 *     ListNode(int x) : val(x), next(nullptr) {}
 *     ListNode(int x, ListNode *next) : val(x), next(next) {}
 * };
 */
class Solution {
public:
    ListNode* mergeTwoLists(ListNode* list1, ListNode* list2) {

        //Dummy Node
        ListNode* newNode = new ListNode(0);
        ListNode* Head = newNode;

        //If any one is null , break the loop
        while(list1 != NULL && list2 != NULL)
        {
            if(list1->val < list2->val)
            {
                Head->next = list1;
                list1 = list1->next;
            } else{
                Head->next = list2;
                list2 = list2->next;
            }

            //move the head everytime the loop runs to reach the next node
            Head = Head->next;
        }

    
        //The list that becomes null, would help the tail
        //to conntect to the other list 
        if(list1 == NULL)
        {
            Head->next = list2;
        } else if(list2 == NULL){
            Head->next = list1;
        }

        //Return the Head
        return newNode->next;        

    }
};