﻿using System;
using System.Collections.Generic;

namespace DSA.DataStructures.Tree;

public class TreeNode<T>
{
    private T value;

    private bool hasParent;

    private List<TreeNode<T>> children;

    public TreeNode(T value)
    {
        if (value == null)
        {
            throw new ArgumentNullException("Cannot insert null value!");
        }
        this.value = value;
        this.children = new List<TreeNode<T>>();
    }

    public T Value
    {
        get { return this.value; }
        set
        {
            this.value = value;
        }
    }

    public int ChildrenCount
    {
        get { return this.children.Count; }
    }

    public void AddChild(TreeNode<T> child)
    {
        if (child == null)
        {
            throw new ArgumentNullException("Cannot insert null value!");
        }
        if (child.hasParent)
        {
            throw new ArgumentException("The node already has a parent!");
        }
        child.hasParent = true;

        this.children.Add(child);
    }

    public TreeNode<T> GetChild(int index)
    {
        return this.children[index];
    }
}

public class Tree<T>
{
    private TreeNode<T> root;

    public Tree(T value)
    {
        if (value == null)
        {
            throw new ArgumentNullException("Cannot insert null value!");
        }
        this.root = new TreeNode<T>(value);
    }

    public Tree(T value, params Tree<T>[] children) : this(value)
    {
        foreach (Tree<T> child in children)
        {
            this.root.AddChild(child.root);
        }
    }

    public TreeNode<T> Root
    {
        get
        {
            return this.root;
        }
    }

    private void PrintDFS(TreeNode<T> root, string spaces)
    {
        if (this.root == null)
        {
            return;
        }
        Console.WriteLine(spaces + root.Value);

        TreeNode<T> child = null;

        for (int i = 0; i < root.ChildrenCount; i++)
        {
            child = root.GetChild(i);
            PrintDFS(child, spaces + "   ");
        }
    }

    public void TraverseDFS()
    {
        this.PrintDFS(this.root, string.Empty);
    }
}


public static class TreeProgram
{
    static void Main()
    {
        Tree<int> tree =

            new Tree<int>(7, new Tree<int>(19, new Tree<int>(1), new Tree<int>(12), new Tree<int>(31)),
            new Tree<int>(21), new Tree<int>(14, new Tree<int>(23), new Tree<int>(6)));

        tree.TraverseDFS();
    }
}