#include <stdio.h>
#include <stdlib.h>

struct Node
{
	int data;
	struct Node *link;
};

struct Node *createNode(int data)
{
	struct Node *next = (struct Node *)malloc(sizeof(struct Node));

	if (next == NULL)
	{
		printf("Memory allocation failed!\n");
		return NULL;
	}

	next->data = data;
	next->link = NULL;

	return next;
}

struct Node *insertAtBeginning(struct Node *head, int data)
{
	struct Node *next = createNode(data);
	next->link = head;
	return next;
}

struct Node *insertAtEnd(struct Node *head, int data)
{
	if (head == NULL)
	{
		return insertAtBeginning(head, data);
	}

	struct Node *current = head;

	while (current->link != NULL)
	{
		current = current->link;
	}

	current->link = createNode(data);

	return head;
}

void printList(struct Node *head)
{
	printf("Linked List: ");
	while (head != NULL)
	{
		printf("%d ", head->data);
		head = head->link;
	}
	printf("\n");
}

int main()
{
	struct Node *head = NULL;

	head = insertAtBeginning(head, 20);
	head = insertAtBeginning(head, 15);
	head = insertAtBeginning(head, 10);
	head = insertAtEnd(head, 30);
	printList(head);

	return 0;
}
