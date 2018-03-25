import React from 'react';
import { Link } from 'react-router-dom';
import HeaderNavigation from '../navbar/HeaderNavigation';
import './Dashboard.css';

import LinkButton from '../button/LinkButton';

const Dashboard = () => (
  <section className="section-dashboard">
    <h2>Dashboard</h2>
    <div className="row">
      <LinkButton to="/dashboard/create">Create New</LinkButton>
    </div>
  </section>
);

export default Dashboard;
