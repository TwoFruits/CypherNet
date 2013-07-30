﻿namespace Dynamic4Neo.Tests
{
    #region

    using CypherNet.Graph;

    #endregion

    internal class TestCypherClause
    {
        public Node actor { get; set; }
        public Node director { get; set; }
        public Node movie { get; set; }
        public Relationship directedBy { get; set; }
        public Relationship hasDirected { get; set; }
    }
}